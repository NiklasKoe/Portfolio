import { Component } from '@angular/core';
import {
  faInstagram,
  faLinkedin,
  faTwitter,
} from '@fortawesome/free-brands-svg-icons';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-homepage',
  standalone: true,
  imports: [FontAwesomeModule, CommonModule],
  templateUrl: './homepage.component.html',
  styleUrl: './homepage.component.scss',
})
export class HomepageComponent {
  //
  public socials: any = [
    {
      icon: faInstagram,
      url: 'https://www.instagram.com/nklsk23/',
      name: 'Instagram',
    },
    {
      icon: faTwitter,
      url: 'https://x.com/dukedo7',
      name: 'Twitter',
    },
    {
      icon: faLinkedin,
      url: 'https://www.linkedin.com/in/niklas-k%C3%B6nig-22b143322/',
      name: 'LinkedIn',
    },
  ];
}
