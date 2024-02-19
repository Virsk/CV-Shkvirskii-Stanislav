import { Component } from '@angular/core';
import { Appellation } from '../../../../../shared/interfaces/appellation';

@Component({
  selector: 'app-interest',
  templateUrl: './interest.component.html',
  styleUrls: ['./interest.component.scss']
})
export class InterestComponent {

  interests: Appellation[] = [
    { date: "Family", appellation: "../../../../../assets/icon/interest/family.svg"},
    { date: "Coding", appellation: "../../../../../assets/icon/interest/code.svg"},
    { date: "Fishing", appellation: "../../../../../assets/icon/interest/fishing.svg"},
    { date: "Cinema", appellation: "../../../../../assets/icon/interest/cinema.svg" },
    { date: "Music", appellation: "../../../../../assets/icon/interest/music.svg" }
  ]
}
