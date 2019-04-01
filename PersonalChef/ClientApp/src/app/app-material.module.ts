import { NgModule } from '@angular/core';
import {
    MatToolbarModule, MatIconModule, MatSidenavModule, MatFormFieldModule, MatInputModule,
    MatListModule, MatButtonModule
} from '@angular/material';

@NgModule({
    imports: [MatToolbarModule, MatIconModule, MatSidenavModule, MatFormFieldModule, MatInputModule,
        MatListModule, MatButtonModule],
    exports: [MatToolbarModule, MatIconModule, MatSidenavModule, MatFormFieldModule, MatInputModule,
        MatListModule, MatButtonModule]
})
export class AppMaterialModule { }
