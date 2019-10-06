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
  currentUser: User | null;
  get isLoggedIn() {
    return this.loggedIn.asObservable();
  }
  get isAdministrator()  {
    return this.currentUser.isAdmin;
  }

  constructor(private router: Router, private repository: RepositoryService, private http: HttpClient) { }

  login(user: User) {
    let routeToLogin: string;
    routeToLogin = environment.urlAddress + '/api/' + 'Auth';
    let credentials = JSON.stringify(user);
    this.http.post(routeToLogin, credentials, {
      headers: new HttpHeaders ({
        "Content-Type" : "application/json"
      })
      }).subscribe(response => {
        let token = (<any>response).token;
        this.currentUser = {
          username: user.username,
          id: user.id,
          password: user.password,
          isAdmin: (<any>response).isAdmin,
          isInactive: user.isInactive,
          name: user.name
        }
        localStorage.setItem('jwt', token);
        this.loggedIn.next(true);
        this.isAdmin.next(this.currentUser.isAdmin);
        this.router.navigate(['/home']);
      }, err => {
        this.loggedIn.next(false);
        window.alert('Molimo unesite ispravne podatke.');
      });
    }


  //   if (user.username !== '' && user.password !== '') {            //dodati logiku za proveru korisnika
  //     this.loggedIn.next(true);
  //     this.router.navigate(['/home']);
  //   }
  // }

  logout() {
    this.loggedIn.next(false);
    localStorage.removeItem('jwt');
    this.currentUser = null;
    this.router.navigate(['/login']);

  }
}
