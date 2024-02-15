import { Component } from '@angular/core';


@Component({
  selector: 'app-change-theme-button',
  templateUrl: './change-theme-button.component.html',
  styleUrls: ['./change-theme-button.component.scss']
})
export class ChangeThemeButtonComponent {
  progressValue: number = 0;

  checkProgress() {
    if (this.progressValue == 0) {
      this.progressValue = 100;
    }
    else {
      this.progressValue = 0;
    }
  }
}
