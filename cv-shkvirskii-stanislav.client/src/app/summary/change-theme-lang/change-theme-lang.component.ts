import { Component } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';


@Component({
  selector: 'app-change-theme-button',
  templateUrl: './change-theme-lang.component.html',
  styleUrls: ['./change-theme-lang.component.scss']
})
export class ChangeThemeLangComponent 
{
  progressValue: number = 0;
  activeLanguage: string = "en";

  constructor(private translate: TranslateService) {
    this.translate.setDefaultLang('en');
  }

  checkProgress() {
    if (this.progressValue == 0) {
      this.progressValue = 100;
    }
    else {
      this.progressValue = 0;
    }
  }

  switchLanguage(language: string) {
    this.translate.use(language);
    this.activeLanguage = language;
  }
}
