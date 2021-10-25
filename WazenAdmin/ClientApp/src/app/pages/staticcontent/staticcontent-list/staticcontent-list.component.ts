import { Component, OnInit } from '@angular/core';
//import { IStaticContentResponse } from '../../../models/IStaticContent';
import { IStaticContent, IStaticContentResponse } from '../../../models/IStaticContent';
import { StaticContentService } from '../../../services/staticcontent.service';

@Component({
    selector: 'app-staticcontent-list',
    templateUrl: './staticcontent-list.component.html',
    styleUrls: ['./staticcontent-list.component.scss']
})

export class StaticContentListComponent implements OnInit {
  staticcontent: IStaticContent[] = [];

  constructor(private _staticContentService: StaticContentService) { }

  ngOnInit(): void {
    this.getStaticContent();
  }

  getStaticContent() {
    this._staticContentService.getStaticContent().subscribe((res: IStaticContentResponse) => {
      console.log(res);
      this.staticcontent = res.data;
      console.log(this.staticcontent);
    })
  }

  deleteStaticContent(staticContentId) {
    var ans = confirm("Do you want to delete StaticContent with Id: " + staticContentId);
    alert(ans)
    if (ans) {
      this._staticContentService.deleteStaticContent(staticContentId).subscribe((data) => {
        this.getStaticContent();
      }, error => console.error(error))
    }
  }
}

