import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { IStatus } from '../../../models/IStatus';
import { IUsersResponse } from '../../../models/IUser';
import { UserService } from '../../../services/user.service';
import { SharedUtils } from '../../../utils/shared-utils';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.scss']
})
/** add-user component*/
export class AddUserComponent implements OnInit {
  /** add-user ctor */
  userForm: FormGroup;
  Id: any;

  constructor(private _formBuilder: FormBuilder, private _router: Router, private _activeRoute: ActivatedRoute, public _sharedUtils: SharedUtils, private _userService: UserService) {
    this.Id = this._activeRoute.snapshot.params.Id;
  }

  ngOnInit(): void {
    this.userForm = this._formBuilder.group({
      name: new FormControl("", [Validators.required]),
      username: new FormControl("", [Validators.required]),
      email: new FormControl("", [Validators.required]),
      // Validators.minLength(5),]),
      password: new FormControl("", [Validators.required]),
      contactNo: new FormControl("", [Validators.required]),
      designation: new FormControl("", [Validators.required]),
     // modifiedBy: new FormControl("", [Validators.required]),
     // modifiedOn: new FormControl("", [Validators.required]),
     // date: new FormControl("", [Validators.required]),
     // createdBy: new FormControl("", [Validators.required]),
     // createdOn: new FormControl("", [Validators.required]),
      isActive: new FormControl(false, [Validators.required]),







    });
    this.Id && this.getUserById();
  }

  getUserById() {

    this._userService.getUserById(this.Id).subscribe((res: IUsersResponse) => {
      console.log(res)
      this.userForm.patchValue(res.data);
      })
    

  }

  /*onSubmit() {
    this._userService.addUser(this.userForm.value).subscribe((res: IStatus) => {
      console.log(res)
    })
  }*/



  onSubmit() {
    if (this.Id) {
      let data = {
        ...this.userForm.value, id: this.Id
      }
      this._userService.updateUser(data).subscribe((res: IStatus) => {
        console.log(res);
        if (res.succeeded) {
          this._router.navigateByUrl("/wazen/users");
        }
      })
    } else {
      this._userService.addUser(this.userForm.value).subscribe((res: IStatus) => {
        console.log(res);

        if (res.succeeded) {
          this._router.navigateByUrl("/wazen/users");
        }
      })
    }
  }
}
