import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { RouterModule } from '@angular/router';
import { SummaryComponent } from './summary/summary.component';
import { HeaderSummaryComponent } from './summary/header-summary/header-summary.component';
import { ContentSummaryComponent } from './summary/content-summary/content-summary.component';
import { ChangeThemeButtonComponent } from './summary/change-theme-button/change-theme-button.component';
import { FormsModule } from '@angular/forms';
import { AboutMeComponent } from './summary/content-summary/about-me/about-me.component';
import { InterestComponent } from './summary/content-summary/about-me/interest/interest.component';
import { HardSkillsComponent } from './summary/content-summary/about-me/hard-skills/hard-skills.component';

@NgModule({
  declarations: [
    AppComponent,
    SummaryComponent,
    HeaderSummaryComponent,

    ContentSummaryComponent,
    AboutMeComponent,
    InterestComponent,
    HardSkillsComponent,

    ChangeThemeButtonComponent,
  ],
  imports: [
    FormsModule,
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot([
      { path: '', component: SummaryComponent, pathMatch: 'full' },
    ]),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
