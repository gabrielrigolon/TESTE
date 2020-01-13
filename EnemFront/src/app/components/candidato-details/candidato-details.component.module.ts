import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { CandidatoDetailsComponent } from './candidato-details.component';
import { CandidatoDetailsRoutingModule } from './candidato-details.component.routing';

@NgModule({
    imports: [
      CommonModule,
      CandidatoDetailsRoutingModule,
      FormsModule
    ],
    declarations: [
      CandidatoDetailsComponent
    ]
  })
  export class CandidatoDetailsModule { }