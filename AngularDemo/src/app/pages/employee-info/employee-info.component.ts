import { Component, OnInit } from '@angular/core';
import {IEmployee} from '../../shared/Interface/iemployee';

@Component({
  selector: 'app-employee-info',
  templateUrl: './employee-info.component.html',
  styleUrls: ['./employee-info.component.css']
})
export class EmployeeInfoComponent implements OnInit {

  constructor() { }
  EmployeeList: IEmployee;
  ngOnInit() {
  }

}
