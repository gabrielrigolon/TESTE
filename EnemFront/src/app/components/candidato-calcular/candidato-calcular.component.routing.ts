import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CandidatoCalcularComponent } from './candidato-calcular.component';

const routes: Routes = [
    { path: '', component: CandidatoCalcularComponent }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })
  export class CandidatoCalcularRoutingModule {}