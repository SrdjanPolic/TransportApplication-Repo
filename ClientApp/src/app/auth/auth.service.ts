import { Injectable } from '@angular/core';
import {Router} from '@angular/router';
import {BehaviorSubject} from 'rxjs';
import {User} from './user.model';
import {RepositoryService} from './../shared/repository.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from './../../environments/environment';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private loggedIn = new BehaviorSubject<boolean>(false);
  private isAdmin = new BehaviorSubject<boolean>(false);
  public currentUser: User | null;
  get isLoggedIn() {
    return this.loggedIn.asObservable();
  }
  get isAdministrator()  {
    return this.isAdmin.asObservable();
  }

  constructor(private router: Router, private repository: RepositoryService, private http: HttpClient) { }

  login(user: User) {
    let routeToLogin: string;
    routeToLogin = environment.urlAddress + '/api/' + 'Auth';
    let credentials = JSON.stringify(user);
    this.http.post(routeToLogin, credentials, {
      headers: new HttpHeaders ({
        'Content-Type' : 'application/json'
      })
      }).subscribe(response => {
        const token = (<any>response).token;
        const administrator = (<any>response).isAdmin;
        this.currentUser = {
          username: user.username,
          id: user.id,
          password: user.password,
          isAdmin: administrator,
          isInactive: user.isInactive,
          name: user.name
        };
        localStorage.setItem('jwt', token);
        localStorage.setItem('username', this.currentUser.username);
        if (this.currentUser.isAdmin) {
          localStorage.setItem('isAdmin', 'true');
        } else { localStorage.setItem('isAdmin', 'false'); }
        this.loggedIn.next(true);
        this.isAdmin.next(administrator);
        this.router.navigate(['/home']);
      }, err => {
        this.loggedIn.next(false);
        window.alert('Korisnik nije autorizovan ili je deaktiviran.');
      });
    }

  logout() {
    this.loggedIn.next(false);
    localStorage.removeItem('jwt');
    localStorage.removeItem('username');
    localStorage.removeItem('isAdmin');
    this.currentUser = null;
    this.router.navigate(['/login']);

  }
}
