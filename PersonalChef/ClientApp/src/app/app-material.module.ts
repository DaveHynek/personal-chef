import { NgModule } from '@angular/core';
import { MatToolbarModule, MatIconModule, MatSidenavModule } from '@angular/material';

@NgModule({
    imports: [MatToolbarModule, MatIconModule, MatSidenavModule],
    exports: [MatToolbarModule, MatIconModule, MatSidenavModule]
})
export class AppMaterialModule { }
