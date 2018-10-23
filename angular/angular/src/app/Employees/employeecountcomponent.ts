import { Component, Input, Output, EventEmitter } from '@angular/core'
@Component({
    selector: 'employee_count',
    templateUrl: 'app/Employees/employeecountcomponent.html',
    styleUrls:['app/Employees/employeecountcomponent.css']
})
export class Employeecountcomponent {

    selectedRadioButtonValue: string = 'All';

    @Output()
    countRadioButtonSelectionChanged: EventEmitter<string> = new EventEmitter<string>();

    @Input()
    all: number;

    @Input()
    male: number;

    @Input()
    female: number;

    onRadioButtonSelectionChange() {
        this.countRadioButtonSelectionChanged.emit(this.selectedRadioButtonValue);
        console.log(this.selectedRadioButtonValue);
    }
}