
import { Component, OnInit } from "@angular/core";
import { IEmployee } from "./empoyees";
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeService } from "./employeeservice";

@Component({
    selector: "my_employee",
    templateUrl: 'app/Employees/Employees.html'
})


export class employeeComponent implements OnInit {
    employee: IEmployee;
    statusMessage: string = 'Loading data. Please wait...';

    constructor(private _employeeService: EmployeeService,
        private _activatedRoute: ActivatedRoute, private _router: Router) { }

    onBackButtonClick(): void {
        this._router.navigate(['/employee']);
    }
    ngOnInit() {
        let empCode: string = this._activatedRoute.snapshot.params['code'];
        this._employeeService.getEmployeesByCode(empCode)
            .subscribe((employeeData) => {
                if (employeeData == null) {
                    this.statusMessage =
                        'Employee with the specified Employee Code does not exist';
                }
                else {
                    this.employee = employeeData;
                }
            },
                (error) => {
                    this.statusMessage =
                        'Problem with the service. Please try again after sometime';
                    console.error(error);
                });
    }

}