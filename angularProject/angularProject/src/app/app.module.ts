import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { RouterModule, Routes } from '@angular/router';


import { AppComponent }  from './app.component';
import { employeecomponent } from './employee/employeecomponent';
import { staffcomponent } from './Staff/staff.component';
import { PageNotFoundComponent } from './PageNotFoundComponent';


const appRoutes: Routes = [
    { path: 'employee', component: employeecomponent },
    { path: 'staff', component: staffcomponent },
    { path: '', redirectTo: '/employee', pathMatch: 'full' },
    { path: '**', component: PageNotFoundComponent }
];

@NgModule({
    imports: [BrowserModule, RouterModule.forRoot(appRoutes)],
    declarations: [AppComponent, employeecomponent, staffcomponent, PageNotFoundComponent],
    bootstrap: [AppComponent],
})
export class AppModule { }
