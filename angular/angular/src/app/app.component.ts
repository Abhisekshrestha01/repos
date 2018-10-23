import { Component } from '@angular/core';

@Component({
  selector: 'my-app',
    templateUrl: 'app/myapp.html',
    styles: ['h1{color:green}']
               
})
export class AppComponent  {
    userText: string = 'Pragim';
    colspan: number = 2;
    PageHeader = "Employee detail";
    firstname: string = "To";
    lastname: string = "ma";
    isBold: boolean= true;
    isItalic: boolean = true;
    fontSize: number = 30;
    addStyle() {
        var style = {
            'font-size.px': this.fontSize,
            'font-style': this.isItalic ? 'italic' : 'normal',
            'font-weight': this.isBold ? 'bold' : 'normal',
        };
        return style;
    }
    getname() {
        return this.firstname + ' ' + this.lastname;
    }
    
}
