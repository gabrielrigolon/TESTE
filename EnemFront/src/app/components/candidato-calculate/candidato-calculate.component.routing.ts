import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CandidatoCalculateComponent } from './candidato-calculate.component';

const routes: Routes = [
    { path: '', component: CandidatoCalculateComponent }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })
  export class CandidatoCalculateRoutingModule {}