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
var UserPreferencesService_1 = require("../Employees/UserPreferencesService");
var Homecomponent = /** @class */ (function () {
    function Homecomponent(_userPreferencesService) {
        this._userPreferencesService = _userPreferencesService;
    }
    Object.defineProperty(Homecomponent.prototype, "colour", {
        get: function () {
            return this._userPreferencesService.colourPreference;
        },
        set: function (value) {
            this._userPreferencesService.colourPreference = value;
        },
        enumerable: true,
        configurable: true
    });
    Homecomponent = __decorate([
        core_1.Component({
            template: "<h1>This is the home page</h1>\n<div>\nColour Preference:\n<input type='text' [(ngModel)]='colour' [style.background]='colour'>\n</div>"
        }),
        __metadata("design:paramtypes", [UserPreferencesService_1.UserPreferenceService])
    ], Homecomponent);
    return Homecomponent;
}());
exports.Homecomponent = Homecomponent;
//# sourceMappingURL=home.component.js.map