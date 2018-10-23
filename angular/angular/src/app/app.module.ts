import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule, Routes } from '@angular/router';
import { EmployeeService } from './Employees/employeeservice';

import { AppComponent } from './app.component';
import { employeeComponent } from './Employees/employeecomponent';
import { Employeelistcomponent } from './Employees/employeeListcomponent';
import { Employeecountcomponent } from './Employees/employeecountcomponent';
import { SimpleComponent } from './Others/simplecomponent';
import { Homecomponent } from './home/home.component';
import { PageNotFoundComponent } from './Others/PageNotFound.component';
import { UserPreferenceService } from './Employees/UserPreferencesService';

const appRoutes: Routes = [
    { path: 'home', component: Homecomponent },
    { path: 'employee', component: Employeelistcomponent },
    { path: 'employee/:code', component: employeeComponent },
    { path: '', redirectTo: '/home', pathMatch: 'full' },
    { path: '**', component: PageNotFoundComponent }
];

@NgModule({
    imports: [BrowserModule, FormsModule, HttpModule, RouterModule.forRoot(appRoutes)],
    declarations: [AppComponent, employeeComponent, Employeelistcomponent, Employeecountcomponent, SimpleComponent, Homecomponent, PageNotFoundComponent],
    bootstrap: [AppComponent],
    providers: [EmployeeService, UserPreferenceService]
})
export class AppModule { }
