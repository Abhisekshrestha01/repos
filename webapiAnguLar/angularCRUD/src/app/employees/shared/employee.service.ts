import { Injectable } from '@angular/core';

import {Employee} from './employee.model'
@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  SelectedEmployee : Employee;
  constructor() { }
}
