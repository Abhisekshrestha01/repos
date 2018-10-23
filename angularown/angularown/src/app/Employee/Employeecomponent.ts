import { Component, OnInit } from '@angular/core';
import { IEmployee } from './employee';
import { EmployeeService } from './EmployeeService';

@Component({
    selector: 'emp-data',
    templateUrl: 'app/Employee/Employeecomponent.html'
})

export class employeecomponent implements OnInit {
    employees: IEmployee[];

    statusMessage: string = "Loading data. Please wait...";


    constructor(private _employeeService: EmployeeService) {

    }
    ngOnInit() {
        this._employeeService.getEmployees()
            .subscribe((employeeData) => this.employees = employeeData, (error) => {
                this.statusMessage = 'Problem with the service.Please try again after sometime';
                console.error(error);
            });
    }
}