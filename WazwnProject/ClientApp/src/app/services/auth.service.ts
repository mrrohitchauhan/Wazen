import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { BehaviorSubject, Observable } from "rxjs";
import { tap } from "rxjs/operators";

@Injectable({
  providedIn: "root",
})
export class AuthService {
  userState: BehaviorSubject<{}> = new BehaviorSubject<{}>(null);
  constructor(private _router: Router, private _httpClient: HttpClient) {
    // this.loadToken();
  }

  loadToken() {
    const user = ''; // this.getUserJson();
    if (Object.keys(user).length) this.userState.next(user);
    else this.userState.next(user);
  }

  //signin(user) {
  //  return this._httpClient.post(`${Constants.SIGNIN}`, user).pipe(
  //    tap((res: ISigninResponse) => {
  //      if (res.status && res.token) {
  //        localStorage.setItem(Constants.USER_TOKEN, res.token);
  //        let user = this.getUserJson();
  //        this.userState.next(user);
  //        this._router.navigateByUrl("/neosoft/dashboard");
  //      }
  //    })
  //  );
  //}
  //signup(user): Observable<IStatus> {
  //  return this._httpClient.post<IStatus>(`${Constants.SIGNUP}`, user);
  //}

  //getMenus() {
  //  let param = { role: this.getUserJson().role };
  //  return this._httpClient.post(`${Constants.GET_MENU}`, param);
  //}

  logout() {
    localStorage.clear();
    this.userState.next({});
    this._router.navigateByUrl("/");
  }

  //getUserJson(): IUserModel {
  //  if (localStorage.getItem(Constants.USER_TOKEN)) {
  //    let jwtPayload = localStorage.getItem(Constants.USER_TOKEN);
  //    return JSON.parse(atob(jwtPayload)) as IUserModel;
  //  } else {
  //    return {} as IUserModel;
  //  }
  //}

  //doesUsernameExist(username) {
  //  return this._httpClient.post(`${Constants.CHECK_USERNAME}`, { username: username });
  //}
}
