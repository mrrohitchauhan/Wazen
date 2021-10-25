import { IStatus } from "./IStatus";

export interface IDashboardBanner {
  id: string;
  imageSource: string;
  productID: string;
  isActive: string;
}

export interface IDashboardBannerResponse extends IStatus {
  data: IDashboardBanner[];
}
