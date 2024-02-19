import { Component } from '@angular/core';
import { Skill } from '../../../../../shared/interfaces/skill';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-hard-skills',
  templateUrl: './hard-skills.component.html',
  styleUrls: ['./hard-skills.component.scss']
})
export class HardSkillsComponent {

  Skills: Skill[] = [];

  constructor(http: HttpClient) {
    http.get<Skill[]>('/content/getskills').subscribe(result => {
      this.Skills = result;
      console.log(result)
    }, error => console.error(error));
  }
}
