import { Component, Input, Output, EventEmitter } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { MatIconRegistry } from '@angular/material';

@Component({
    selector: 'app-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.sass']
})
export class HeaderComponent {
    @Input() menuOpen: boolean;
    @Output() menuOpenChange: EventEmitter<boolean> = new EventEmitter<boolean>();

    constructor(iconRegistry: MatIconRegistry,
        sanitizer: DomSanitizer) {
        iconRegistry.addSvgIcon(
            'menu', sanitizer.bypassSecurityTrustResourceUrl('assets/img/examples/outline-menu-24px.svg'));
    }

    menuClicked(event: MouseEvent) {
    this.menuOpen = true;
    this.menuOpenChange.emit(this.menuOpen);
    }
}
