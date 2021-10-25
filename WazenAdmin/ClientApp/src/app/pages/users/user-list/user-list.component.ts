import { Component, OnInit } from '@angular/core';
//import { IStaticContentResponse } from '../../../models/IStaticContent';
import { IUser, IUsersResponse } from '../../../models/IUser';
import { UserService } from '../../../services/user.service';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.scss']
})

export class UserComponent implements OnInit {
  users: IUser[] = [];

  constructor(private _userService: UserService) { }

  ngOnInit(): void {
    this.getUser();
  }

  getUser() {
    this._userService.getUser().subscribe((res: IUsersResponse) => {
      console.log(res);
      this.users = res.data;
      console.log(this.users);
    })
  }

  deleteUser(Id) {
    var ans = confirm("Do you want to delete user with Id: " + Id);
    alert(ans)
    if (ans) {
      this._userService.deleteUser(Id).subscribe((data) => {
        this.getUser();
      }, error => console.error(error))
    }
  }
}
