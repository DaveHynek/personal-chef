import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';

// Project Modules
import { AppRoutingModule } from './app-routing.module';
import { AppMaterialModule } from './app-material.module';

// Project Components
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HeaderComponent } from './header/header.component';


@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        HeaderComponent
    ],
    imports: [
        BrowserModule,
        AppRoutingModule,
        AppMaterialModule,
        BrowserAnimationsModule,
        HttpClientModule
    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }
