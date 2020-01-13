import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  { path: '', redirectTo: 'candidatos', pathMatch: 'full' },
  { path: 'candidato-list', loadChildren:  './components/candidato-list/candidato-list.component.module#CandidatoListModule'},
  { path: 'candidato', loadChildren:  './components/candidato-list/candidato-list.component.module#CandidatoListModule'},
  { path: 'candidatos', loadChildren: './components/candidato-list/candidato-list.component.module#CandidatoListModule'},
  { path: 'candidato-create', loadChildren: './components/candidato-create/candidato-create.component.module#CandidatoCreateModule'},
  { path: 'add', loadChildren: './components/candidato-create/candidato-create.component.module#CandidatoCreateModule'},
  { path: 'update/:id', loadChildren: './components/candidato-update/candidato-update.component.module#CandidatoUpdateModule'},
  { path: 'details/:id', loadChildren: './components/candidato-details/candidato-details.component.module#CandidatoDetailsModule'},
  { path: 'exibirResultados', loadChildren: './components/candidato-calcular/candidato-calcular.component.module#CandidatoCalcularModule'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
