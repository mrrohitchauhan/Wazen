import { environment } from "../../environments/environment";

export class AppConstants {
  public static API_ENDPOINT: string = environment.apiUrl;

  public static USER_TOKEN: string = 'USER-TOKEN';

  /*URL For Roles*/
  public static GET_ROLES: string = `${AppConstants.API_ENDPOINT}Role/all`;
  public static GET_ROLES_BY_ID: string = `${AppConstants.API_ENDPOINT}Role/`
  public static ADD_ROLES: string = `${AppConstants.API_ENDPOINT}Role`;
  public static UPDATE_ROLES: string = `${AppConstants.API_ENDPOINT}Role`
  public static DELETE_ROLES: string = `${AppConstants.API_ENDPOINT}Role/`;

  /*URL For StaticContent*/
  public static GET_STATICCONTENT: string = `${AppConstants.API_ENDPOINT}StaticContent/all`;
  public static ADD_STATICCONTENT: string = `${AppConstants.API_ENDPOINT}StaticContent/`;
  public static GET_STATICCONTENT_BY_ID: string = `${AppConstants.API_ENDPOINT}StaticContent/`;
  public static UPDATE_STATICCONTENT: string = `${AppConstants.API_ENDPOINT}StaticContent`;
  public static DELETE_STATICCONTENT: string = `${AppConstants.API_ENDPOINT}StaticContent/`;

  /*URL For HomePageBanner*/
  public static GET_HOMEPAGEBANNER: string = `${AppConstants.API_ENDPOINT}HomePageBanner/all`;
  public static ADD_HOMEPAGEBANNER: string = `${AppConstants.API_ENDPOINT}HomePageBanner/`;
  public static GET_HOMEPAGEBANNER_BY_ID: string = `${AppConstants.API_ENDPOINT}HomePageBanner/`;
  public static UPDATE_HOMEPAGEBANNER: string = `${AppConstants.API_ENDPOINT}HomePageBanner`;
  public static DELETE_HOMEPAGEBANNER: string = `${AppConstants.API_ENDPOINT}HomePageBanner/`;

  /*URL For Users*/
  public static GET_USERS: string = `${AppConstants.API_ENDPOINT}User/all`;
  public static ADD_USERS: string = `${AppConstants.API_ENDPOINT}User`;
  public static UPDATE_USERS: string = `${AppConstants.API_ENDPOINT}User/`;
  public static GET_USER_BY_ID: string = `${AppConstants.API_ENDPOINT}User/`;
  public static DELETE_USERS: string = `${AppConstants.API_ENDPOINT}User/`;

  /*URL For Customers*/
  public static GET_CUSTOMERS: string = `${AppConstants.API_ENDPOINT}Customer/all`;
  public static ADD_CUSTOMERS: string = `${AppConstants.API_ENDPOINT}Customer`;
  public static DELETE_CUSTOMERS: string = `${AppConstants.API_ENDPOINT}Customer/`;
  public static GET_CUSTOMER_BY_ID: string = `${AppConstants.API_ENDPOINT}Customer/`;
  public static UPDATE_CUSTOMERS: string = `${AppConstants.API_ENDPOINT}Customer/`;

  /*URL For InsuranceCompanies*/
  public static GET_INSURANCECOMPANIES: string = `${AppConstants.API_ENDPOINT}InsuranceCompanies/all`;
  public static ADD_INSURANCECOMPANIES: string = `${AppConstants.API_ENDPOINT}InsuranceCompanies/`;
  public static DELETE_INSURANCECOMPANIES: string = `${AppConstants.API_ENDPOINT}InsuranceCompanies/`;
  public static GET_INSURANCECOMPANIES_BY_ID: string = `${AppConstants.API_ENDPOINT}InsuranceCompanies/`;
  public static UPDATE_INSURANCECOMPANIES: string = `${AppConstants.API_ENDPOINT}InsuranceCompanies`;

}
