import { IStatus } from "./IStatus";

export interface IUser {
  id: string;
  name: string;
  username: string;
  password: string;
  ContactNo: string;
  Designation: string;
  Password: string;
  ModifiedBy: boolean;
  ModifiedOn: string;
  CreatedBy: string;
  CreatedOn: boolean;
  Date: string;

}

export interface IUsersResponse extends IStatus {
  data: IUser[];
}
