import { IStatus } from "./IStatus";




export interface ICustomers {
  ID: string;
  Salutation: string;
  EnglishFirstName: string;
  EnglishMiddleName: string;
  EnglishLastName: string;
  ArabicFirstName: string;
  ArabicMiddleName: string;
  ArabicLastName: string;
  Address: string;
  NationalID: string;
  IQAMA: string;
  CompanyCR: string;
  Email: string;
  Mobile: string;
  TelephoneNumber: string;
  DateOfBirth: string;
  Gender: string;
  Occupation: string;
  EducationID: string;
  MaritalStatusID: string;
  DriverID: string;
}


export interface ICustomersResponse extends IStatus {
  data: ICustomers[];
}
