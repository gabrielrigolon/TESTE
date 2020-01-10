import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CandidatoListComponent } from './candidato-list/candidato-list.component';
import { HttpClientModule } from '@angular/common/http';
import { CandidatoCreateComponent } from './candidato-create/candidato-create.component';
import { CandidatoUpdateComponent } from './candidato-update/candidato-update.component';
import { CandidatoDetailsComponent } from './candidato-details/candidato-details.component';
import { FormsModule } from '@angular/forms';
import { CandidatoCalcularComponent } from './candidato-calcular/candidato-calcular.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { ModalModule } from 'ngx-bootstrap/modal';

@NgModule({
   declarations: [
      AppComponent,
      CandidatoListComponent,
      CandidatoCreateComponent,
      CandidatoUpdateComponent,
      CandidatoDetailsComponent,
      CandidatoCalcularComponent,
      CandidatoCalcularComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      HttpClientModule,
      FormsModule,
      BrowserAnimationsModule,
      ToastrModule.forRoot(),
      ModalModule.forRoot()

   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
