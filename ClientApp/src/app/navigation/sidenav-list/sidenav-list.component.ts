import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import {AuthService} from './../../auth/auth.service';

@Component({
  selector: 'app-sidenav-list',
  templateUrl: './sidenav-list.component.html',
  styleUrls: ['./sidenav-list.component.css']
})
export class SidenavListComponent implements OnInit {
  @Output() sidenavClose = new EventEmitter();
  isAdministrator: boolean;
  constructor(public authService: AuthService) { }

  ngOnInit() {
    this.authService.isAdministrator.subscribe(value => this.isAdministrator = value);
  }
  get isAdmin(): string {
    return localStorage.getItem('isAdmin');
  }

  public onSidenavClose = () => {
    this.sidenavClose.emit();
  }
  public onLogout() {
    this.onSidenavClose();
    this.authService.logout();
  }
}
