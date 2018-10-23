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
var Employeecountcomponent = /** @class */ (function () {
    function Employeecountcomponent() {
        this.selectedRadioButtonValue = 'All';
        this.countRadioButtonSelectionChanged = new core_1.EventEmitter();
    }
    Employeecountcomponent.prototype.onRadioButtonSelectionChange = function () {
        this.countRadioButtonSelectionChanged.emit(this.selectedRadioButtonValue);
        console.log(this.selectedRadioButtonValue);
    };
    __decorate([
        core_1.Output(),
        __metadata("design:type", core_1.EventEmitter)
    ], Employeecountcomponent.prototype, "countRadioButtonSelectionChanged", void 0);
    __decorate([
        core_1.Input(),
        __metadata("design:type", Number)
    ], Employeecountcomponent.prototype, "all", void 0);
    __decorate([
        core_1.Input(),
        __metadata("design:type", Number)
    ], Employeecountcomponent.prototype, "male", void 0);
    __decorate([
        core_1.Input(),
        __metadata("design:type", Number)
    ], Employeecountcomponent.prototype, "female", void 0);
    Employeecountcomponent = __decorate([
        core_1.Component({
            selector: 'employee_count',
            templateUrl: 'app/Employees/employeecountcomponent.html',
            styleUrls: ['app/Employees/employeecountcomponent.css']
        })
    ], Employeecountcomponent);
    return Employeecountcomponent;
}());
exports.Employeecountcomponent = Employeecountcomponent;
//# sourceMappingURL=employeecountcomponent.js.map