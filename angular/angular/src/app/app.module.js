"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var platform_browser_1 = require("@angular/platform-browser");
var forms_1 = require("@angular/forms");
var http_1 = require("@angular/http");
var router_1 = require("@angular/router");
var employeeservice_1 = require("./Employees/employeeservice");
var app_component_1 = require("./app.component");
var employeecomponent_1 = require("./Employees/employeecomponent");
var employeeListcomponent_1 = require("./Employees/employeeListcomponent");
var employeecountcomponent_1 = require("./Employees/employeecountcomponent");
var simplecomponent_1 = require("./Others/simplecomponent");
var home_component_1 = require("./home/home.component");
var PageNotFound_component_1 = require("./Others/PageNotFound.component");
var UserPreferencesService_1 = require("./Employees/UserPreferencesService");
var appRoutes = [
    { path: 'home', component: home_component_1.Homecomponent },
    { path: 'employee', component: employeeListcomponent_1.Employeelistcomponent },
    { path: 'employee/:code', component: employeecomponent_1.employeeComponent },
    { path: '', redirectTo: '/home', pathMatch: 'full' },
    { path: '**', component: PageNotFound_component_1.PageNotFoundComponent }
];
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            imports: [platform_browser_1.BrowserModule, forms_1.FormsModule, http_1.HttpModule, router_1.RouterModule.forRoot(appRoutes)],
            declarations: [app_component_1.AppComponent, employeecomponent_1.employeeComponent, employeeListcomponent_1.Employeelistcomponent, employeecountcomponent_1.Employeecountcomponent, simplecomponent_1.SimpleComponent, home_component_1.Homecomponent, PageNotFound_component_1.PageNotFoundComponent],
            bootstrap: [app_component_1.AppComponent],
            providers: [employeeservice_1.EmployeeService, UserPreferencesService_1.UserPreferenceService]
        })
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map