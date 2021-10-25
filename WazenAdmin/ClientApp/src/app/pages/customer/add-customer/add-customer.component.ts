import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ICustomersResponse } from '../../../models/ICustomers';
import { IStatus } from '../../../models/IStatus';
import { CustomerService } from '../../../services/customer.service';
import { SharedUtils } from '../../../utils/shared-utils';

@Component({
  selector: 'app-add-customer',
  templateUrl: './add-customer.component.html',
  styleUrls: ['./add-customer.component.scss']
})
/** add-customer component*/
export class AddCustomerComponent implements OnInit {
  /** add-role ctor */
  customerForm: FormGroup;
  customerId: any;

  constructor(private _formBuilder: FormBuilder, private _router: Router, private _activeRoute: ActivatedRoute, public _sharedUtils: SharedUtils, private _customerService: CustomerService) {
    this.customerId = this._activeRoute.snapshot.params.customerId;
  }

  ngOnInit(): void {
    this.customerForm = this._formBuilder.group({
      salutation: new FormControl("", [Validators.required]),
      englishFirstName: new FormControl("", [Validators.required]),
      englishMiddleName: new FormControl("", [Validators.required]),
      englishLastName: new FormControl("", [Validators.required]),
      arabicFirstName: new FormControl("", [Validators.required]),
      arabicMiddleName: new FormControl("", [Validators.required]),
      arabicLastName: new FormControl("", [Validators.required]),
      address: new FormControl("", [Validators.required]),
      iqama: new FormControl("", [Validators.required]),
      companyCR: new FormControl("", [Validators.required]),
      email: new FormControl("", [Validators.required]),
      mobile: new FormControl("", [Validators.required]),
      telephoneNumber: new FormControl("", [Validators.required]),
      dateOfBirth: new FormControl("", [Validators.required]),
      gender: new FormControl("", [Validators.required]),
      occupation: new FormControl(0, [Validators.required]),
      educationID: new FormControl(0, [Validators.required]),
      maritalStatusID: new FormControl(0, [Validators.required]),
      driverID: new FormControl("", [Validators.required]),

    });
    this.customerId && this.getCustomerById();
  }
  onSubmit() {
    if (this.customerId) {
      let data = {
        ...this.customerForm.value, id: this.customerId
      }
      this._customerService.updateCustomer(data).subscribe((res: IStatus) => {
        console.log(res)
        if (res.succeeded) {
          this._router.navigateByUrl("/wazen/customer-list");
        }
        
      })
    }
    else {
      this._customerService.addCustomer(this.customerForm.value).subscribe((res: IStatus) => {
        console.log(res)
      })
    }
  }

  

  getCustomerById() {
    this._customerService.getCustomerById(this.customerId).subscribe((res: ICustomersResponse) => {
      console.log(res)
      this.customerForm.patchValue(res.data);
    })
  }
}
