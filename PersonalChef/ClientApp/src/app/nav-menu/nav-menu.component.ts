import { Component, Input, Output, EventEmitter } from '@angular/core';

@Component({
    selector: 'app-nav-menu',
    templateUrl: './nav-menu.component.html',
    styleUrls: ['./nav-menu.component.sass']
})
export class NavMenuComponent {
    @Input() menuOpen: boolean;
    @Output() menuOpenChange: EventEmitter<boolean> = new EventEmitter<boolean>();

    menuClosed() {
        this.menuOpen = false;
        this.menuOpenChange.emit(this.menuOpen);
    }
}
