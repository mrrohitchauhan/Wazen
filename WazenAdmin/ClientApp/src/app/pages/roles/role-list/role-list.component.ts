import { Component, OnInit } from '@angular/core';
import { IRoles, IRolesResponse } from '../../../models/IRole';
import { RoleService } from '../../../services/role.service';

@Component({
  selector: 'app-role-list',
  templateUrl: './role-list.component.html',
  styleUrls: ['./role-list.component.scss']
})

export class RoleListComponent implements OnInit {
  users: IRoles[] = [];

  constructor(private _roleService: RoleService) { }

  ngOnInit(): void {
    this.getRoles();
  }

  getRoles() {
    this._roleService.getRoles().subscribe((res: IRolesResponse) => {
      console.log(res);
      this.users = res.data;
    })
  }

  deleteRole(roleId) {
    var ans = confirm("Do you want to delete role with Id: " + roleId);
    alert(ans)
    if (ans) {
      this._roleService.deleteRole(roleId).subscribe((data) => {
        this.getRoles();
      }, error => console.error(error))
    }
  }


    updateRole(id){
      
    }
}

