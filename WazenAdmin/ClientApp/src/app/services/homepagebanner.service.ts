import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IHomePageBannerResponse } from '../models/IHomePageBanner';
import { IStatus } from '../models/IStatus';
import { AppConstants } from '../utils/app.constants';

@Injectable()
export class HomePageBannerService {

  constructor(private _httpClient: HttpClient) { }

  addHomePageBanner(homepagebanners: any): Observable<IStatus> {
    return this._httpClient.post<IStatus>(`${AppConstants.ADD_HOMEPAGEBANNER}`, homepagebanners);
  }

  getHomePageBanner(): Observable<IHomePageBannerResponse> {
    return this._httpClient.get<IHomePageBannerResponse>(`${AppConstants.GET_HOMEPAGEBANNER}`);
  }

  getHomePageBannerById(homePageBannerId): Observable<IHomePageBannerResponse> {
    return this._httpClient.get<IHomePageBannerResponse>(`${AppConstants.GET_HOMEPAGEBANNER_BY_ID}${homePageBannerId}`);
  }

  updateHomePageBanner(homepagebanner: any): Observable<IStatus> {
    return this._httpClient.put<IStatus>(`${AppConstants.UPDATE_HOMEPAGEBANNER}`, homepagebanner);
  }

  deleteHomePageBanner(homePageBannerId): Observable<IHomePageBannerResponse> {
    return this._httpClient.delete<IHomePageBannerResponse>(`${AppConstants.DELETE_STATICCONTENT}${homePageBannerId}`);
  }

}
