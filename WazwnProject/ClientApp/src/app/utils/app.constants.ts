import { environment } from "../../environments/environment";

export class AppConstants {
  public static API_ENDPOINT: string = environment.apiUrl;

  public static USER_TOKEN: string = 'USER-TOKEN';

  public static GET_DASHBOARD_BANNER: string = `${AppConstants.API_ENDPOINT}getBanners`;

  public static GET_ROLES: string = `${AppConstants.API_ENDPOINT}Role/all`;
  public static ADD_ROLES: string = `${AppConstants.API_ENDPOINT}Role/all`;
}
