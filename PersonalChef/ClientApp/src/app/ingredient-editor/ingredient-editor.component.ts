import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-ingredient-editor',
    templateUrl: './ingredient-editor.component.html',
    styleUrls: ['./ingredient-editor.component.sass']
})
export class IngredientEditorComponent implements OnInit {
    typesOfShoes: string[] = ['Boots', 'Clogs', 'Loafers', 'Moccasins', 'Sneakers'];

    ngOnInit() {

    }
}
