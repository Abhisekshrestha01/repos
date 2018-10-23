import { Component, OnInit } from '@angular/core';
import { IEmployee } from './empoyees';
import { EmployeeService } from './employeeservice'
import { UserPreferenceService } from './UserPreferencesService';

@Component({
    selector: 'list_employee',
    templateUrl:'app/Employees/employeeListcomponent.html',
    styleUrls: ['app/Employees/employeeListcomponent.css'],
    
})

export class Employeelistcomponent implements OnInit {

    selectedEmployeeCountRadioButton: string = 'All';

    employees: IEmployee[];
    
    statusMessage: string = "Loading data. Please wait...";
    

    constructor(private _employeeService: EmployeeService, private _userPreferencesService: UserPreferenceService) {
        
    }
    get colour(): string {
        return this._userPreferencesService.colourPreference;
    }
    set colour(value: string) {
        this._userPreferencesService.colourPreference = value; 
    }






    ngOnInit() {
        this._employeeService.getEmployees()
            .subscribe((employeeData) => this.employees = employeeData, (error) => {
                this.statusMessage = 'Problem with the service.Please try again after sometime';
                console.error(error);
            });
    }

    gettotalEmployeesCount(): number {
        return this.employees.length;
    }

    gettotalmaleEmployeesCount(): number {
        return this.employees.filter(e => e.gender === "Male").length;
    }

    gettotalfemaleEmployeesCount(): number {
        return this.employees.filter(e => e.gender === "Female").length;
    }

    onEmployeeCountRadioButtonChange(selectedRadioButtonValue: string): void {
        this.selectedEmployeeCountRadioButton = selectedRadioButtonValue;
    }

}