import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { IStatus } from '../../../models/IStatus';
import { RoleService } from '../../../services/role.service';
import { SharedUtils } from '../../../utils/shared-utils';

@Component({
  selector: 'app-add-role',
  templateUrl: './add-role.component.html',
  styleUrls: ['./add-role.component.scss']
})
/** add-role component*/
export class AddRoleComponent implements OnInit {
  /** add-role ctor */
  roleForm: FormGroup;
  roleId: any;

  constructor(private _formBuilder: FormBuilder, private _router: Router, private _activeRoute: ActivatedRoute, public _sharedUtils: SharedUtils, private _roleService: RoleService) {
    this.roleId = this._activeRoute.snapshot.params.roleId;
  }

  ngOnInit(): void {
    this.roleForm = this._formBuilder.group({
      roleName: new FormControl("", [Validators.required]),
      roleArabicName: new FormControl("",[Validators.required]),
      description: new FormControl("", [
        Validators.required,
        Validators.minLength(5),
      ]),
    });
    this.roleId && this.getStaffById();
  }

  getStaffById() {

  }

  onSubmit() {
    this._roleService.addRole(this.roleForm.value).subscribe((res: IStatus) => {
      console.log(res)
    })
  }
}
