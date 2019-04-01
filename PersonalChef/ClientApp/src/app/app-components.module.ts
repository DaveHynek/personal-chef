import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';
import { AppMaterialModule } from './app-material.module';

import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HeaderComponent } from './header/header.component';
import { IngredientEditorComponent } from './ingredient-editor/ingredient-editor.component';

@NgModule({
    declarations: [
        NavMenuComponent,
        HeaderComponent,
        IngredientEditorComponent
    ],
    imports: [CommonModule, AppMaterialModule],
    exports: [NavMenuComponent, HeaderComponent, IngredientEditorComponent, AppMaterialModule]
})
export class AppComponentModule { }
