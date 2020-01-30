import { Component } from '@angular/core';
import { DeductionService } from '../common/deduction.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
    constructor(private deductionService: DeductionService) {

    }

    get() {
        alert('yes');

        this.deductionService.get().subscribe(data => {
        });
    }
}
