import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';
import { AppMaterialModule } from './app-material.module';

import { HeaderComponent } from './header/header.component';
import { IngredientEditorComponent } from './ingredient-editor/ingredient-editor.component';

@NgModule({
    declarations: [
        HeaderComponent,
        IngredientEditorComponent
    ],
    imports: [CommonModule, AppMaterialModule],
    exports: [HeaderComponent, IngredientEditorComponent, AppMaterialModule]
})
export class AppComponentModule { }
