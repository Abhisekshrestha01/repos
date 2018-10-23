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
var employeeservice_1 = require("./employeeservice");
var UserPreferencesService_1 = require("./UserPreferencesService");
var Employeelistcomponent = /** @class */ (function () {
    function Employeelistcomponent(_employeeService, _userPreferencesService) {
        this._employeeService = _employeeService;
        this._userPreferencesService = _userPreferencesService;
        this.selectedEmployeeCountRadioButton = 'All';
        this.statusMessage = "Loading data. Please wait...";
    }
    Object.defineProperty(Employeelistcomponent.prototype, "colour", {
        get: function () {
            return this._userPreferencesService.colourPreference;
        },
        set: function (value) {
            this._userPreferencesService.colourPreference = value;
        },
        enumerable: true,
        configurable: true
    });
    Employeelistcomponent.prototype.ngOnInit = function () {
        var _this = this;
        this._employeeService.getEmployees()
            .subscribe(function (employeeData) { return _this.employees = employeeData; }, function (error) {
            _this.statusMessage = 'Problem with the service.Please try again after sometime';
            console.error(error);
        });
    };
    Employeelistcomponent.prototype.gettotalEmployeesCount = function () {
        return this.employees.length;
    };
    Employeelistcomponent.prototype.gettotalmaleEmployeesCount = function () {
        return this.employees.filter(function (e) { return e.gender === "Male"; }).length;
    };
    Employeelistcomponent.prototype.gettotalfemaleEmployeesCount = function () {
        return this.employees.filter(function (e) { return e.gender === "Female"; }).length;
    };
    Employeelistcomponent.prototype.onEmployeeCountRadioButtonChange = function (selectedRadioButtonValue) {
        this.selectedEmployeeCountRadioButton = selectedRadioButtonValue;
    };
    Employeelistcomponent = __decorate([
        core_1.Component({
            selector: 'list_employee',
            templateUrl: 'app/Employees/employeeListcomponent.html',
            styleUrls: ['app/Employees/employeeListcomponent.css'],
        }),
        __metadata("design:paramtypes", [employeeservice_1.EmployeeService, UserPreferencesService_1.UserPreferenceService])
    ], Employeelistcomponent);
    return Employeelistcomponent;
}());
exports.Employeelistcomponent = Employeelistcomponent;
//# sourceMappingURL=employeeListcomponent.js.map