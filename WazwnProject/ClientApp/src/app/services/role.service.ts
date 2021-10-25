import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IRoles, IRolesResponse } from '../models/IRole';
import { IStatus } from '../models/IStatus';
import { AppConstants } from '../utils/app.constants';

@Injectable()
export class RoleService {

  constructor(private _httpClient: HttpClient) { }

  addRole(role: any): Observable<IStatus> {
    return this._httpClient.post<IStatus>(`${AppConstants.ADD_ROLES}`, role);
  }

  getRoles(): Observable<IRolesResponse> {
    return this._httpClient.get<IRolesResponse>(`${AppConstants.GET_ROLES}`);
  }

  getRoleById() {

  }

  deleteRole() {

  }

}
