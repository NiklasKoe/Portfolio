import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { NgxTypewriterComponent } from '@omnedia/ngx-typewriter';
import { faInstagram, faLinkedin, faGithub, faTwitter } from '@fortawesome/free-brands-svg-icons';
import { SidebarComponent } from "../../components/sidebar/sidebar.component";
import { Page } from 'src/models';

@Component({
    selector: 'app-personalpage',
    templateUrl: './personalpage.component.html',
    styleUrls: ['./personalpage.component.scss'],
    standalone: true,
    imports: [
        NgxTypewriterComponent,
        FontAwesomeModule,
        SidebarComponent
    ]
})
export class PersonalpageComponent implements OnInit {

    constructor(private elem: ElementRef) {

    }

    /* ICONS */
    faInstagram = faInstagram;
    faLinkedIn = faLinkedin;
    faGithub = faGithub;
    faTwitter = faTwitter;

    /* VARIABLES */
    writeSpeed: number = 40;
    deleteDelay: number = 3500;
    writeDelay: number = 50;
    currentId: number = 0;
    words: string[] = ['Software Developer.', 'Fullstack Engineer.', 'Internal Applications.'];

    @ViewChild('home') homeDiv!: HTMLElement;
    @ViewChild('skills') skillsDiv!: HTMLElement;
    @ViewChild('cv') cvDiv!: HTMLElement;
    @ViewChild('contact') contactDiv!: HTMLElement;
    pages: Page[] = [
        { name: 'Home', el: this.homeDiv },
        { name: 'Skills', el: this.skillsDiv },
        { name: 'CV', el: this.cvDiv },
        { name: 'Contact', el: this.contactDiv },
    ];

    ngOnInit(): void {
        // (click)="scroll(target)"
    }

    currentlyHidden: boolean = true;
    toggleInfoVisibility(value: boolean) {
        this.currentlyHidden = !value;
    }

    print($event: any) {

        console.log(this.homeDiv!)
    }

    scrollTo(nameOfElement: string) {
        //
        this.elem.nativeElement.querySelectorAll('')
    }

    scroll(el: HTMLElement) {
        console.log(el)
        el.scrollIntoView({ behavior: 'smooth' });
    }
}
