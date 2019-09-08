import { Injectable } from '@angular/core';
import { CanActivate, CanActivateChild, CanLoad, Route, UrlSegment, ActivatedRouteSnapshot,
         RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';
import {map, take} from 'rxjs/operators';
import {AuthService} from './auth.service';
import {JwtHelper} from 'angular2-jwt';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {

  constructor(
    private authService: AuthService,
    private router: Router,
  ) {}

  // canActivate(
  //   next: ActivatedRouteSnapshot,
  //   state: RouterStateSnapshot
  //   ): Observable<boolean> {
  //   return this.authService.isLoggedIn
  //   .pipe(
  //     take(1),
  //     map((isLoggedIn: boolean) => {
  //       if (!isLoggedIn) {
  //         this.router.navigate(['/login']);
  //         return false;
  //       }
  //       return true;
  //     })
  //   );
  // }
  canActivate() {
    let jwtHelper: JwtHelper = new JwtHelper();
    let token = localStorage.getItem("jwt");

    //if (token && !this.jwtHelper.isTokenExpired() {
      if (token && jwtHelper.isTokenExpired(token, 900)) {
      return true;
    }
    this.router.navigate(['/login']);
    return false;
  }

}
