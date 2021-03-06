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
var EmployeeService_1 = require("./EmployeeService");
var employeecomponent = /** @class */ (function () {
    function employeecomponent(_employeeService) {
        this._employeeService = _employeeService;
        this.statusMessage = "Loading data. Please wait...";
    }
    employeecomponent.prototype.ngOnInit = function () {
        var _this = this;
        this._employeeService.getEmployees()
            .subscribe(function (employeeData) { return _this.employees = employeeData; }, function (error) {
            _this.statusMessage = 'Problem with the service.Please try again after sometime';
            console.error(error);
        });
    };
    employeecomponent = __decorate([
        core_1.Component({
            selector: 'emp-data',
            templateUrl: 'app/Employee/Employeecomponent.html'
        }),
        __metadata("design:paramtypes", [EmployeeService_1.EmployeeService])
    ], employeecomponent);
    return employeecomponent;
}());
exports.employeecomponent = employeecomponent;
//# sourceMappingURL=Employeecomponent.js.map