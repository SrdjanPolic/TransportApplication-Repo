import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { AuthService } from './../../auth/auth.service';
import { Observable } from 'rxjs';
@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  @Output() public sidenavToggle = new EventEmitter();
  @Output() public toggleTheme = new EventEmitter();
  isLoggedIn$: Observable<boolean>; 

  constructor(private authService: AuthService) { }

  ngOnInit() {
    this.isLoggedIn$ = this.authService.isLoggedIn;
  }

  public onToggleSidenav = () => {
    this.sidenavToggle.emit();
  }

  public onToggleTheme = () => {
    this.toggleTheme.emit();
  }

  onLogout() {
    this.authService.logout();
  }


 

}
