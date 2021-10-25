import { Component, OnInit } from '@angular/core';

declare interface RouteInfo {
  path: string;
  title: string;
  icon: string;
  class: string;
}
export const ROUTES: RouteInfo[] = [
  {
    path: "/wazen/dashboard",
    title: "Dashboard",
    icon: "design_app",
    class: "",
  },
  {
    path: "/wazen/roles",
    title: "Roles",
    icon: "design_app",
    class: "",
  },
  {
    path: "/wazen/add-role",
    title: "Add roles",
    icon: "design_app",
    class: "",
  },
  {
    path: "/wazen/student",
    title: "Students",
    icon: "design_app",
    class: "",
  },
];

@Component({
    selector: 'app-navbar',
    templateUrl: './navbar.component.html',
    styleUrls: ['./navbar.component.scss']
})
/** navbar component*/
export class NavbarComponent implements OnInit {
  /** navbar ctor */
  menuItems: any[];
    constructor() {

  }


  //async getMenus() {
  //  this._authService.getMenus().subscribe((menus: any) => {
  //    let userMenu = menus.result;
  //    ROUTES.push(...userMenu);
  //    this.menuItems = ROUTES.filter((menuItem) => menuItem);
  //  });
  //}

  ngOnInit() {
    this.menuItems = ROUTES.filter((menuItem) => menuItem);
    //this.getMenus();
  }

}
