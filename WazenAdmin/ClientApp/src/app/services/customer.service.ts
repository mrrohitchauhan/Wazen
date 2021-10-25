import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ICustomersResponse } from '../models/ICustomers';
import { IStatus } from '../models/IStatus';
import { AppConstants } from '../utils/app.constants';

@Injectable()
export class CustomerService {
  constructor(private _httpClient: HttpClient) { }

  addCustomer(role: any): Observable<IStatus> {
    return this._httpClient.post<IStatus>(`${AppConstants.ADD_CUSTOMERS}`, role);
  }

  getCustomers(): Observable<ICustomersResponse> {
    return this._httpClient.get<ICustomersResponse>(`${AppConstants.GET_CUSTOMERS}`);
  }

  updateCustomer(customer: any): Observable<IStatus> {
    return this._httpClient.put<IStatus>(`${AppConstants.UPDATE_CUSTOMERS}`, customer);
  }
  deleteCustomer(customerId): Observable<ICustomersResponse> {
    return this._httpClient.delete<ICustomersResponse>(`${AppConstants.DELETE_CUSTOMERS}${customerId}`);
  }

  getCustomerById(customerId): Observable<ICustomersResponse> {
    return this._httpClient.get<ICustomersResponse>(`${AppConstants.GET_CUSTOMER_BY_ID}${customerId}`);
  }


}
