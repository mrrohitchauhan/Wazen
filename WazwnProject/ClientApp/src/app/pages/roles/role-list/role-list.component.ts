import { Component, OnInit } from '@angular/core';
import { IRolesResponse } from '../../../models/IRole';
import { RoleService } from '../../../services/role.service';

@Component({
    selector: 'app-role-list',
    templateUrl: './role-list.component.html',
    styleUrls: ['./role-list.component.scss']
})

export class RoleListComponent implements OnInit {
  constructor(private _roleService: RoleService) { }

  ngOnInit(): void {
    this.getRoles();
  }

  getRoles() {
    this._roleService.getRoles().subscribe((res: IRolesResponse) => {
      console.log(res);
    })
  }
}
