import { Component } from '@angular/core';
import { UserPreferenceService } from '../Employees/UserPreferencesService';

@Component({
    template: `<h1>This is the home page</h1>
<div>
Colour Preference:
<input type='text' [(ngModel)]='colour' [style.background]='colour'>
</div>`


})
export class Homecomponent {
    constructor(private _userPreferencesService: UserPreferenceService) {

    }
    get colour(): string {
        return this._userPreferencesService.colourPreference;
    }

    set colour(value: string) {
        this._userPreferencesService.colourPreference = value;
    }
}