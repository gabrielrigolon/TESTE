import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CandidatoDetailsComponent } from './candidato-details.component';

const routes: Routes = [
    { path: '', component: CandidatoDetailsComponent }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })
  export class CandidatoDetailsRoutingModule {}