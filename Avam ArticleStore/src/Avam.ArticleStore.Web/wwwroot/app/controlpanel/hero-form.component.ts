import { Component } from 'angular2/core';
import { NgForm, NgClass }    from 'angular2/common';

import { Hero }    from './hero';
@Component({
  selector: 'hero-form',
  templateUrl: 'app/controlpanel/hero-form.component.html',
  styleUrls: ['app/controlpanel/form.css'],
  directives: [NgClass]
})
export class HeroFormComponent {
  powers = ['Really Smart', 'Super Flexible',
            'Super Hot', 'Weather Changer'];
  //model = new Hero(18, 'Dr IQ', this.powers[0], 'Chuck Overstreet');
  model ={};
  submitted = false;
  onSubmit(heroForm) { 
      this.submitted = true; 
    }
  // Reset the form with a new hero AND restore 'pristine' class state
  // by toggling 'active' flag which causes the form
  // to be removed/re-added in a tick via NgIf
  // TODO: Workaround until NgForm has a reset method (#6822)
  active = true;
  newHero() {
    this.model = new Hero(42, '', '');
    this.active = false;
    setTimeout(()=> this.active=true, 0);
  }
}