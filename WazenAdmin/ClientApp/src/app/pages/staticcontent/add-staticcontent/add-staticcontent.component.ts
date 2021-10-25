import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { IStaticContentResponse } from '../../../models/IStaticContent';
import { IStatus } from '../../../models/IStatus';
import { StaticContentService } from '../../../services/staticcontent.service';
import { SharedUtils } from '../../../utils/shared-utils';

@Component({
  selector: 'app-add-staticcontent',
  templateUrl: './add-staticcontent.component.html',
  styleUrls: ['./add-staticcontent.component.scss']
})

export class AddStaticContentComponent implements OnInit {
 
  staticContentForm: FormGroup;
  staticContentId: any;

  constructor(private _formBuilder: FormBuilder, private _router: Router, private _activeRoute: ActivatedRoute, public _sharedUtils: SharedUtils, private _staticContentService: StaticContentService) {
    this.staticContentId = this._activeRoute.snapshot.params.staticContentId;
  }

  ngOnInit(): void {
    this.staticContentForm = this._formBuilder.group({
      aboutUs: new FormControl("", [Validators.required]),
      termsAndCondition: new FormControl("", [Validators.required]),
      partnerName : new FormControl("", [Validators.required]),
      partnerLogo: new FormControl("", [Validators.required]),
      redirectedURL: new FormControl("", [Validators.required]),
      status: new FormControl("", [Validators.required]),
      nameOfTheCompany: new FormControl("", [Validators.required]),
      address: new FormControl("", [Validators.required]),
      contactNo: new FormControl("", [Validators.required]),
      emailAddress: new FormControl("", [Validators.required]),
      socialMediaIcon: new FormControl("", [Validators.required]),
      socialMediaLink: new FormControl("", [Validators.required]),
      websiteLink: new FormControl("", [Validators.required]),
      googleLocation: new FormControl("", [Validators.required]),
    });
    this.staticContentId && this.getStaticContentById();
  }

  getStaticContentById() {
    this._staticContentService.getStaticContentById(this.staticContentId).subscribe((res: IStaticContentResponse) => {
      console.log(res)
      this.staticContentForm.patchValue(res.data);
    })
  }

  onSubmit() {
    if (this.staticContentId) {
      let data = {
        ...this.staticContentForm.value, id: this.staticContentId
      }
      this._staticContentService.updateStaticContent(data).subscribe((res: IStatus) => {
        console.log(res);
        if (res.succeeded) {
          this._router.navigateByUrl("/wazen/staticcontent-list");
        }
      })
    } else {
      this._staticContentService.addStaticContent(this.staticContentForm.value).subscribe((res: IStatus) => {
        console.log(res);
        if (res.succeeded) {
          this._router.navigateByUrl("/wazen/staticcontent-list");
        }
      })
    }
  }  
}
