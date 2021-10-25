import { IStatus } from "./IStatus";

export interface IHomePageBanner {
  id: string;
  imageSource : string;
  productID : string;
  isActive: string;
  createdBy: string;
  createdOn: string;
  modifiedBy : string;
  modifiedOn : string;
}

export interface IHomePageBannerResponse extends IStatus {
  data: IHomePageBanner[];
}
