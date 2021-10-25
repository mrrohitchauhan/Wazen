import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IInsuranceCompaniesResponse } from '../models/IInsuranceCompanies';
import { IStatus } from '../models/IStatus';
import { AppConstants } from '../utils/app.constants';

@Injectable()
export class InsuranceCompaniesService {
  constructor(private _httpClient: HttpClient) { }

  addInsuranceCompanies(insurancecompanies: any): Observable<IStatus> {
    return this._httpClient.post<IStatus>(`${AppConstants.ADD_INSURANCECOMPANIES}`, insurancecompanies);
  }

  getInsuranceCompanies(): Observable<IInsuranceCompaniesResponse> {
    return this._httpClient.get<IInsuranceCompaniesResponse>(`${AppConstants.GET_INSURANCECOMPANIES}`);
  }

  updateInsuranceCompanies(InsuranceCompanies: any): Observable<IStatus> {
    return this._httpClient.put<IStatus>(`${AppConstants.UPDATE_INSURANCECOMPANIES}`, InsuranceCompanies);
  }
  deleteInsuranceCompanies(icId): Observable<IInsuranceCompaniesResponse> {
    return this._httpClient.delete<IInsuranceCompaniesResponse>(`${AppConstants.DELETE_INSURANCECOMPANIES}${icId}`);
  }

  getInsuranceCompaniesById(icId): Observable<IInsuranceCompaniesResponse> {
    return this._httpClient.get<IInsuranceCompaniesResponse>(`${AppConstants.GET_INSURANCECOMPANIES_BY_ID}${icId}`);
  }


}
