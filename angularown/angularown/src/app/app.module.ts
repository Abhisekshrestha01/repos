import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { employeecomponent } from './Employee/Employeecomponent';
import { staffcomponent } from './staff/Staffcomponent';
import { PageNotFoundComponent } from './PageNotFoundComponent';
import { EmployeeService } from './Employee/EmployeeService';
import { IEmployee } from './Employee/employee';

const appRoutes: Routes = [
    { path: 'employee', component: employeecomponent },
    { path: 'staff', component: staffcomponent },
    { path: '', redirectTo: '/employee', pathMatch: 'full' },
    { path: '**', component: PageNotFoundComponent }
];

@NgModule({
    imports: [BrowserModule, FormsModule, HttpModule, RouterModule.forRoot(appRoutes)],
    declarations: [AppComponent, employeecomponent, staffcomponent, PageNotFoundComponent],
    bootstrap: [AppComponent],
    providers: [EmployeeService]
})
export class AppModule { }
