import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IStaticContentResponse } from '../models/IStaticContent';
import { IStatus } from '../models/IStatus';
import { AppConstants } from '../utils/app.constants';

@Injectable()
export class StaticContentService {

  constructor(private _httpClient: HttpClient) { }

  addStaticContent(staticcontent: any): Observable<IStatus> {
    return this._httpClient.post<IStatus>(`${AppConstants.ADD_STATICCONTENT}`, staticcontent);
  }

  getStaticContent(): Observable<IStaticContentResponse> {
    return this._httpClient.get<IStaticContentResponse>(`${AppConstants.GET_STATICCONTENT}`);
  }

  getStaticContentById(staticContentId): Observable<IStaticContentResponse> {
    return this._httpClient.get<IStaticContentResponse>(`${AppConstants.GET_STATICCONTENT_BY_ID}${staticContentId}`);
  }

  updateStaticContent(staticcontent: any): Observable<IStatus> {
    return this._httpClient.put<IStatus>(`${AppConstants.UPDATE_STATICCONTENT}`, staticcontent);
  }

  deleteStaticContent(staticContentId): Observable<IStaticContentResponse> {
    return this._httpClient.delete<IStaticContentResponse>(`${AppConstants.DELETE_STATICCONTENT}${staticContentId}`);
  }

}
