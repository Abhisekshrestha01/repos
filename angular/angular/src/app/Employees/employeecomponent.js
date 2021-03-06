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
var employeeComponent = /** @class */ (function () {
    function employeeComponent(_employeeService, _activatedRoute, _router) {
        this._employeeService = _employeeService;
        this._activatedRoute = _activatedRoute;
        this._router = _router;
        this.statusMessage = 'Loading data. Please wait...';
    }
    employeeComponent.prototype.onBackButtonClick = function () {
        this._router.navigate(['/employee']);
    };
    employeeComponent.prototype.ngOnInit = function () {
        var _this = this;
        var empCode = this._activatedRoute.snapshot.params['code'];
        this._employeeService.getEmployeesByCode(empCode)
            .subscribe(function (employeeData) {
            if (employeeData == null) {
                _this.statusMessage =
                    'Employee with the specified Employee Code does not exist';
            }
            else {
                _this.employee = employeeData;
            }
        }, function (error) {
            _this.statusMessage =
                'Problem with the service. Please try again after sometime';
            console.error(error);
        });
    };
    employeeComponent = __decorate([
        core_1.Component({
            selector: "my_employee",
            templateUrl: 'app/Employees/Employees.html'
        }),
        __metadata("design:paramtypes", [employeeservice_1.EmployeeService,
            router_1.ActivatedRoute, router_1.Router])
    ], employeeComponent);
    return employeeComponent;
}());
exports.employeeComponent = employeeComponent;
//# sourceMappingURL=employeecomponent.js.map