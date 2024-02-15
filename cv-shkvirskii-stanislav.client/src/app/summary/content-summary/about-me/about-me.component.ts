import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Content } from '../../../../shared/interfaces/content';

@Component({
  selector: 'app-about-me',
  templateUrl: './about-me.component.html',
  styleUrls: ['./about-me.component.scss']
})
export class AboutMeComponent {
  AllContent: Content[] = [];
  
  constructor(http: HttpClient) {
    http.get<Content[]>( '/content/getcontent').subscribe(result => {
      this.AllContent = result;
      console.log(result)
    }, error => console.error(error));
  }
}
