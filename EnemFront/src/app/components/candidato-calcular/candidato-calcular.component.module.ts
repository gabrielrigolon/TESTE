import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { CandidatoCalcularComponent } from './candidato-calcular.component';
import { CandidatoCalcularRoutingModule } from './candidato-calcular.component.routing';

@NgModule({
    imports: [
      CommonModule,
      CandidatoCalcularRoutingModule,
      FormsModule
    ],
    declarations: [
      CandidatoCalcularComponent
    ]
  })
  export class CandidatoCalcularModule { }