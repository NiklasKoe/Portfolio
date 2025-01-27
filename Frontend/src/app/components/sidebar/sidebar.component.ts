import { CommonModule } from '@angular/common';
import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Page } from 'src/models';

@Component({
  selector: 'app-sidebar',
  imports: [CommonModule],
  templateUrl: './sidebar.component.html',
  styleUrl: './sidebar.component.scss'
})
export class SidebarComponent {

  @Input() pages?: Page[];
  @Output() pageSelectedEvent = new EventEmitter<HTMLElement>();


  emit(page: Page) {
    this.pageSelectedEvent.emit(page.el);
  }

  currentlyHidden: boolean = true;
  toggleInfoVisibility(value: boolean) {
    this.currentlyHidden = !value;
  }
}
