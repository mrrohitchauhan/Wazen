import { IStatus } from "./IStatus";

export interface IRoles {
  ID: string;
  RoleName: string;
  RoleArabicName: string;
  Description: string;
  IsActive: boolean;
}

export interface IRolesResponse extends IStatus {
  data: IRoles[];
}
