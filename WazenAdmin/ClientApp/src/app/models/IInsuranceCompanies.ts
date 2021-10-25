import { IStatus } from "./IStatus";

export interface IInsuranceCompanies {
  icid: string;
  nameoftheIC: string
  nameofICAdmin: string;
  icAdminEmailAddress: string;
  icAdminPassword: string;
  icAdminPhoneNumber: string;
  startDateofCollaboration: Date;
  location: string;
  city: string;
  officeNumber: string;
  agreements: string;
  noofPolicies: string;
  configurableParameters: string;
  adminExpenseForNAJM: string;
  adminExpenseForELM: string;
  bankFees: string;
  defaultExpenses: string;
  sharingPercentageForCancellation: string;
  sharingPercentageForAdministrationFees: string;
  commissionAgreed: string;
  apiAvailable: string;
  endpointURL: string;
  requestType: string;
  header: string;
  body: string;
  cancelAPIAvailable: string;
  cancelEndpointURL: string;
  cancelRequestType: string;
  cancelHeader: string;
  cancelBody: string;
  refundEndpointURL: string;
  refundRequestType: string;
  refundHeader: string;
  refundBody: string;
  addOnsRemoveEndpointURL: string;
  addOnsRemoveRequestType: string;
  addOnsRemoveHeader: string;
  addOnsRemoveBody: string;
  addOnsRemovePolicyPricing: string;
  isActive: string;
  createdBy: number;
  createdOn: Date;
  modifiedBy: number;
  modifiedOn: Date;
}


export interface IInsuranceCompaniesResponse extends IStatus {
  data: IInsuranceCompanies[];
}
