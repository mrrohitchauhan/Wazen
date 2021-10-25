import { Component, OnInit } from '@angular/core';
import { IHomePageBanner, IHomePageBannerResponse } from '../../../models/IHomePageBanner';
import { HomePageBannerService } from '../../../services/homepagebanner.service';

@Component({
    selector: 'app-homepagebanner-list',
    templateUrl: './homepagebanner-list.component.html',
    styleUrls: ['./homepagebanner-list.component.scss']
})

export class HomePageBannerListComponent implements OnInit {
  homepagebanners: IHomePageBanner[] = [];
  constructor(private _homePageBannerService: HomePageBannerService) { }

  ngOnInit(): void {
    this.getHomePageBanner();
  }

  getHomePageBanner() {
    this._homePageBannerService.getHomePageBanner().subscribe((res: IHomePageBannerResponse) => {
      console.log(res);
      this.homepagebanners = res.data;
      console.log(this.homepagebanners);
    })
  }

  deleteHomePageBanner(homePageBannerId) {
    var ans = confirm("Do you want to delete HomePageBanner with Id: " + homePageBannerId);
    alert(ans)
    if (ans) {
      this._homePageBannerService.deleteHomePageBanner(homePageBannerId).subscribe((data) => {
        this.getHomePageBanner();
      }, error => console.error(error))
    }
  }
}



