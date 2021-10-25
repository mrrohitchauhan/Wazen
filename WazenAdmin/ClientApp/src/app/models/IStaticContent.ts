import { IStatus } from "./IStatus";

export interface IStaticContent {
  id: string;
  aboutUs: string;
  termsAndCondition: string;
  partnerName: string;
  partnerLogo: string;
  redirectedURL: string;
  status: string;
  nameOfTheCompany: string;
  address: string;
  contactNo: string;
  emailAddress: string;
  socialMediaIcon: string;
  socialMediaLink: string;
  websiteLink: string;
  googleLocation: string;
}

export interface IStaticContentResponse extends IStatus {
  data: IStaticContent[];
}
