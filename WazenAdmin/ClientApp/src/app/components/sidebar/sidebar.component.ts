import { Component } from '@angular/core';

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
    path: "/wazen/insurancecompanies",
    title: "Insurance Companies",
    icon: "design_app",
    class: "",
  },
  {
    path: "/wazen/customer",
    title: "Customers",
    icon: "design_app",
    class: "",
  },
  {
    path: "/wazen/users",
    title: "Users",
    icon: "design_app",
    class: "",
  },
  {
    path: "/wazen/homepagebanner-list",
    title: "Banners",
    icon: "design_app",
    class: "",
  },{
    path: "/wazen/staticcontent-list",
    title: "Static Contents",
    icon: "design_app",
    class: "",
  },
];
@Component({
    selector: 'app-sidebar',
    templateUrl: './sidebar.component.html',
    styleUrls: ['./sidebar.component.scss']
})
/** sidebar component*/
export class SidebarComponent {
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
