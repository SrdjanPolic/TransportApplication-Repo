import { RepositoryService } from './../../shared/repository.service';
import { Component, OnInit, AfterViewInit, ViewChild } from '@angular/core';
import { MatTableDataSource, MatSort, MatPaginator } from '@angular/material';
import { User } from '../../auth/user.model';
import { ErrorHandlerService } from '../../shared/error-handler.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})
export class UserListComponent implements OnInit, AfterViewInit {

  public displayedColumns = ['username', 'isAdmin', 'isInactive', 'update'];
  public dataSource = new MatTableDataSource<User>();

  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;

  constructor(private repoService: RepositoryService, private errorService: ErrorHandlerService, private router: Router) { }

  ngOnInit() {
    this.getAllUsers();
  }

  ngAfterViewInit(): void {
     this.dataSource.sort = this.sort;
     this.dataSource.paginator = this.paginator;
  }

  public getAllUsers = () => {
    this.repoService.getData('api/Users')
    .subscribe(res => {
      this.dataSource.data = res as User[];
    },
    (error) => {
      this.errorService.handleError(error);
    })
  }

  public doFilter = (value: string) => {
    this.dataSource.filter = value.trim().toLocaleLowerCase();
  }

  public redirectToDetails = (id: string) => {
    let url: string = `/Users/${id}`;
    this.router.navigate([url]);
  }

  public redirectToUpdate = (id: string) => {
    let url: string = `/user/update/${id}`;
    this.router.navigate([url]);
  }
}
