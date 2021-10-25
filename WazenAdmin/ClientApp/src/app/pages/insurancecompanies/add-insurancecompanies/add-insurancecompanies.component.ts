import { OnInit, Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { IInsuranceCompaniesResponse} from '../../../models/IInsuranceCompanies';
import { IStatus } from '../../../models/IStatus';
import { InsuranceCompaniesService } from '../../../services/InsuranceCompanies.service';
import { SharedUtils } from '../../../utils/shared-utils';

@Component({
  selector: 'app-add-insurance-companies',
  templateUrl: './add-insurancecompanies.component.html',
  styleUrls: ['./add-insurancecompanies.component.scss']
})

/** add-InsuranceCompanies component*/
export class AddInsuranceCompaniesComponent implements OnInit {
  /** add-role ctor */
  insuranceCompaniesForm: FormGroup;
  InsuranceCompaniesId: any;

  constructor(private _formBuilder: FormBuilder, private _router: Router, private _activeRoute: ActivatedRoute, public _sharedUtils: SharedUtils, private _InsuranceCompaniesService: InsuranceCompaniesService) {
    this.InsuranceCompaniesId = this._activeRoute.snapshot.params.icid;
  }

  ngOnInit(): void {
    this.insuranceCompaniesForm = this._formBuilder.group({
      nameoftheIC: new FormControl("", [Validators.required]),
      nameofICAdmin: new FormControl("", [Validators.required]),
      icAdminEmailAddress: new FormControl("", [Validators.required]),
      icAdminPassword: new FormControl("", [Validators.required]),
      icAdminPhoneNumber: new FormControl("", [Validators.required]),
      startDateofCollaboration: new FormControl("", [Validators.required]),
      location: new FormControl("", [Validators.required]),
      city: new FormControl("", [Validators.required]),
      officeNumber: new FormControl("", [Validators.required]),
      agreements: new FormControl("", [Validators.required]),
      noofPolicies: new FormControl("", [Validators.required]),
      configurableParameters: new FormControl("", [Validators.required]),
      adminExpenseForNAJM: new FormControl("", [Validators.required]),
      adminExpenseForELM: new FormControl("", [Validators.required]),
      bankFees: new FormControl("", [Validators.required]),
      defaultExpenses: new FormControl("", [Validators.required]),
      sharingPercentageForCancellation: new FormControl("", [Validators.required]),
      sharingPercentageForAdministrationFees: new FormControl("", [Validators.required]),
      commissionAgreed: new FormControl("", [Validators.required]),
      apiAvailable: new FormControl("", [Validators.required]),
      endpointURL: new FormControl("", [Validators.required]),
      requestType: new FormControl("", [Validators.required]),
      header: new FormControl("", [Validators.required]),
      body: new FormControl("", [Validators.required]),
      cancelAPIAvailable: new FormControl("", [Validators.required]),
      cancelEndpointURL: new FormControl("", [Validators.required]),
      cancelRequestType: new FormControl("", [Validators.required]),
      cancelHeader: new FormControl("", [Validators.required]),
      cancelBody: new FormControl("", [Validators.required]),
      refundEndpointURL: new FormControl("", [Validators.required]),
      refundRequestType: new FormControl("", [Validators.required]),
      refundHeader: new FormControl("", [Validators.required]),
      refundBody: new FormControl("", [Validators.required]),
      addOnsRemoveEndpointURL: new FormControl("", [Validators.required]),
      addOnsRemoveRequestType: new FormControl("", [Validators.required]),
      addOnsRemoveHeader: new FormControl("", [Validators.required]),
      addOnsRemoveBody: new FormControl("", [Validators.required]),
      addOnsRemovePolicyPricing: new FormControl("", [Validators.required]),
      isActive: new FormControl("", [Validators.required]),
      createdBy: new FormControl(12.1, [Validators.required]),
      createdOn: new FormControl("", [Validators.required]),
      modifiedBy: new FormControl(12.1, [Validators.required]),
      modifiedOn: new FormControl("", [Validators.required]),
    });
    this.InsuranceCompaniesId && this.getInsuranceCompaniesById();
  }
  onSubmit() {
    if (this.InsuranceCompaniesId) {
      
      let data = {
        ...this.insuranceCompaniesForm.value, icid: this.InsuranceCompaniesId
      }
      this._InsuranceCompaniesService.updateInsuranceCompanies(data).subscribe((res: IStatus) => {
        console.log(res)
        if (res.succeeded) {
          this._router.navigateByUrl("/wazen/insurancecompanies-list");
        }

      })
    }
    else {
      this._InsuranceCompaniesService.addInsuranceCompanies(this.insuranceCompaniesForm.value).subscribe((res: IStatus) => {
        console.log(res)
        if (res.succeeded) {
          this._router.navigateByUrl("/wazen/insurancecompanies-list");
        }
      })
    }
  }



  getInsuranceCompaniesById() {
    this._InsuranceCompaniesService.getInsuranceCompaniesById(this.InsuranceCompaniesId).subscribe((res: IInsuranceCompaniesResponse) => {
      console.log(res)
      this.insuranceCompaniesForm.patchValue(res.data);
    })
  }
}
