import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { RecipeViewerComponent } from './recipe-viewer/recipe-viewer.component';
import { HomeComponent } from './home/home.component';

const appRoutes: Routes = [
    { path: 'recipe-viewer', component: RecipeViewerComponent },
    { path: '**', component: HomeComponent }
];

@NgModule({
    declarations: [HomeComponent, RecipeViewerComponent],
    imports: [RouterModule.forRoot(appRoutes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
