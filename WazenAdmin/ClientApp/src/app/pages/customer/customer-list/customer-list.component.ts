import { Component } from '@angular/core';
import { ICustomers, ICustomersResponse } from '../../../models/ICustomers';
import { CustomerService } from '../../../services/customer.service';

@Component({
    selector: 'app-customer-list',
    templateUrl: './customer-list.component.html',
    styleUrls: ['./customer-list.component.scss']
})
/** customer-list component*/
export class CustomerListComponent {
  users: ICustomers[] = [];
  /** customer-list ctor */
  constructor(private _customerService: CustomerService) { }

  ngOnInit(): void {
    this.getCustomers();
  }

  getCustomers() {
    this._customerService.getCustomers().subscribe((res: ICustomersResponse) => {
      console.log(res);
      this.users = res.data;
    })
  }
  deleteCustomer(customerId) {
    var ans = confirm("Do you want to delete role with Id: " + customerId);
    alert(ans)
    if (ans) {
      this._customerService.deleteCustomer(customerId).subscribe((data) => {
        this.getCustomers();
      }, error => console.error(error))
    }
  }
}
