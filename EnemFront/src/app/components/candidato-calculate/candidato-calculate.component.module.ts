import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { CandidatoCalculateComponent } from './candidato-calculate.component';
import { CandidatoCalculateRoutingModule } from './candidato-calculate.component.routing';

@NgModule({
    imports: [
      CommonModule,
      CandidatoCalculateRoutingModule,
      FormsModule
    ],
    declarations: [
      CandidatoCalculateComponent
    ]
  })
  export class CandidatoCalculateModule { }