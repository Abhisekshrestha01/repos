"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var router_1 = require("@angular/router");
var employeeservice_1 = require("./employeeservice");
var employeedetailcomponent = /** @class */ (function () {
    function employeedetailcomponent(_employeeService, _activateRoute) {
        this._employeeService = _employeeService;
        this._activateRoute = _activateRoute;
        this.statusMessage = 'Loading data. Please wait...';
    }
    employeedetailcomponent.prototype.ngOnInit = function () {
        var _this = this;
        var empCode = this._activateRoute.snapshot.params['code'];
        this._employeeService.getEmployeesByCode(empCode).subscribe(function (employeData) {
            if (employeData == null) {
                _this.statusMessage = 'Employee with the specified Employee Code does not exist';
            }
            else {
                _this.employee = employeData,
                ;
            }
        }, function (error) {
            _this.statusMessage = 'Problem with the service. Please try again after sometime';
            console.log(error);
        });
    };
    employeedetailcomponent = __decorate([
        core_1.Component({
            selector: "my_employee1",
            templateUrl: 'app/Employee/employeedetailcomponent.html'
        }),
        __metadata("design:paramtypes", [employeeservice_1.EmployeeService, router_1.ActivatedRoute])
    ], employeedetailcomponent);
    return employeedetailcomponent;
}());
exports.employeedetailcomponent = employeedetailcomponent;
//# sourceMappingURL=employeedetailcomponent.js.map