import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IUsersResponse } from '../models/IUser';
import { IStatus } from '../models/IStatus';
import { AppConstants } from '../utils/app.constants';

@Injectable()
export class UserService {

  constructor(private _httpClient: HttpClient) { }

  addUser(user: any): Observable<IStatus> {
    return this._httpClient.post<IStatus>(`${AppConstants.ADD_USERS}`, user);
  }

  getUser(): Observable<IUsersResponse> {
    return this._httpClient.get<IUsersResponse>(`${AppConstants.GET_USERS}`);
  }

 
  getUserById(Id): Observable<IUsersResponse> {
    return this._httpClient.get<IUsersResponse>(`${AppConstants.GET_USER_BY_ID}${Id}`);
  }

  deleteUser(id): Observable<IUsersResponse> {
    return this._httpClient.delete<IUsersResponse>(`${AppConstants.DELETE_USERS}${id}`);
  }



  updateUser(user: any): Observable<IStatus> {
    return this._httpClient.put<IStatus>(`${AppConstants.UPDATE_USERS}`, user);
  }

}

  


