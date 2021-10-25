import { Component, OnInit } from '@angular/core';
import { IInsuranceCompanies, IInsuranceCompaniesResponse } from '../../../models/IInsuranceCompanies';
import { InsuranceCompaniesService } from '../../../services/insurancecompanies.service';

@Component({
  selector: 'app-insurancecompanies-list',
  templateUrl: './insurancecompanies-list.component.html',
  styleUrls: ['./insurancecompanies-list.component.scss']
})

export class InsuranceCompaniesListComponent implements OnInit{
  insurancecompanies: IInsuranceCompanies[] = [];
  constructor(private _insuranceCompaniesService: InsuranceCompaniesService) { }

  ngOnInit(): void {
    this.getInsuranceCompanies();
  }

  getInsuranceCompanies() {
    this._insuranceCompaniesService.getInsuranceCompanies().subscribe((res: IInsuranceCompaniesResponse) => {
      console.log(res);
      this.insurancecompanies = res.data;
    })
  }
  deleteInsuranceCompanies(insuranceCompaniesId) {
    var ans = confirm("Do you want to delete Insurance Companies with Id: " + insuranceCompaniesId);
       if (ans) {
      this._insuranceCompaniesService.deleteInsuranceCompanies(insuranceCompaniesId).subscribe((data) => {
        this.getInsuranceCompanies();
      }, error => console.error(error))
    }
  }
}
