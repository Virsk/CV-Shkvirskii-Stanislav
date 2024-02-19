import { HttpClient, HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import { TranslateModule, TranslateLoader } from '@ngx-translate/core';

import { AppComponent } from './app.component';
import { RouterModule } from '@angular/router';
import { SummaryComponent } from './summary/summary.component';
import { HeaderSummaryComponent } from './summary/header-summary/header-summary.component';
import { ContentSummaryComponent } from './summary/content-summary/content-summary.component';
import { ChangeThemeLangComponent  } from './summary/change-theme-lang/change-theme-lang.component';
import { FormsModule } from '@angular/forms';
import { AboutMeComponent } from './summary/content-summary/about-me/about-me.component';
import { InterestComponent } from './summary/content-summary/about-me/interest/interest.component';
import { HardSkillsComponent } from './summary/content-summary/about-me/hard-skills/hard-skills.component';
import { WorkSpaseComponent } from './summary/content-summary/about-me/work-spase/work-spase.component';


export function HttpLoaderFactory(http: HttpClient) {
  return new TranslateHttpLoader(http);
}

@NgModule({
  declarations: [
    AppComponent,
    SummaryComponent,
    HeaderSummaryComponent,

    ContentSummaryComponent,
    AboutMeComponent,
    InterestComponent,
    HardSkillsComponent,
    WorkSpaseComponent,

    ChangeThemeLangComponent ,
  ],
  imports: [
    FormsModule,
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot([
      { path: '', component: SummaryComponent, pathMatch: 'full' },
    ]),
    TranslateModule.forRoot({
      loader: {
        provide: TranslateLoader,
        useFactory: HttpLoaderFactory,
        deps: [HttpClient]
      },
    }),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
