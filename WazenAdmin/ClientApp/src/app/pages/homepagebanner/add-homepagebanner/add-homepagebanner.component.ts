import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { IHomePageBannerResponse } from '../../../models/IHomePageBanner';
import { IStatus } from '../../../models/IStatus';
import { HomePageBannerService } from '../../../services/homepagebanner.service';
import { SharedUtils } from '../../../utils/shared-utils';

@Component({
    selector: 'app-add-homepagebanner',
    templateUrl: './add-homepagebanner.component.html',
    styleUrls: ['./add-homepagebanner.component.scss']
})

export class AddHomePageBannerComponent implements OnInit {

  homePageBannerForm: FormGroup;
  homePageBannerId: any;

  constructor(private _formBuilder: FormBuilder, private _router: Router, private _activeRoute: ActivatedRoute, public _sharedUtils: SharedUtils, private _homePageBannerService: HomePageBannerService) {
    this.homePageBannerId = this._activeRoute.snapshot.params.homePageBannerId;
  }

  ngOnInit(): void {
    this.homePageBannerForm = this._formBuilder.group({      
      imageSource: new FormControl("", [Validators.required]),
      productID: new FormControl("", [Validators.required]),
      isActive: new FormControl("", [Validators.required]),    
    });
    this.homePageBannerId && this.getHomePageBannerById();
  }

  getHomePageBannerById() {
    this._homePageBannerService.getHomePageBannerById(this.homePageBannerId).subscribe((res: IHomePageBannerResponse) => {
      console.log(res)
      this.homePageBannerForm.patchValue(res.data);
    })
  }

  onSubmit() {
    if (this.homePageBannerId) {
      let data = {
        ...this.homePageBannerForm.value, id: this.homePageBannerId
      }
      this._homePageBannerService.updateHomePageBanner(data).subscribe((res: IStatus) => {
        console.log(res);
        if (res.succeeded) {
          this._router.navigateByUrl("/wazen/homepagebanner-list");
        }
      })
    } else {
      this._homePageBannerService.addHomePageBanner(this.homePageBannerForm.value).subscribe((res: IStatus) => {
        console.log(res);
        if (res.succeeded) {
          this._router.navigateByUrl("/wazen/homepagebanner-list");
        }
      })
    }
  }
}
