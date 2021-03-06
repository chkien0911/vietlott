import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatTableModule } from '@angular/material/table';
import {MatInputModule} from '@angular/material/input';

import { AppComponent } from './app.component';
import { DrawGameComponent } from './vietlott/draw-game/drawgame.component';

@NgModule({
  declarations: [
    AppComponent, DrawGameComponent
  ],
  imports: [
    BrowserModule, BrowserAnimationsModule, MatTableModule, MatInputModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
