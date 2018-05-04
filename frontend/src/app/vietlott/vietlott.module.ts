import 'hammerjs';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { HttpModule } from '@angular/http';
import { CommonModule } from '@angular/common';

import { DemoMaterialModule } from '../demo-material-module';
import { MatTableModule } from '@angular/material/table';
import { CdkTableModule } from '@angular/cdk/table';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FlexLayoutModule } from '@angular/flex-layout';

import { VietlottRoutes } from './vietlott.routing';
import { DrawGameComponent } from './draw-game/drawgame.component';

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(VietlottRoutes),
    DemoMaterialModule,
    HttpModule,
    FormsModule,
    ReactiveFormsModule,
    FlexLayoutModule,
    MatTableModule,
    CdkTableModule
  ],
  providers: [

  ],
  entryComponents: [
  ],
  declarations: [
    DrawGameComponent
  ]
})

export class VietlottModule { }
