import { Candidato } from '../candidato.model';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CandidatoServiceService } from '../candidatoService.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-candidato-create',
  templateUrl: './candidato-create.component.html',
  styleUrls: ['./candidato-create.component.css']
})
export class CandidatoCreateComponent implements OnInit {

  candidato: Candidato = new Candidato();

  submitted = false;

  constructor(private candidatoService: CandidatoServiceService,
              private router: Router,
              private toastr: ToastrService) { }

  ngOnInit() {
  }

  newCandidato(): void {
    this.submitted = false;
    this.candidato = new Candidato();
  }

  save() {
    this.candidatoService.createCandidato(this.candidato)
      .subscribe(data => {
        this.toastr.success('Hello world!', 'Toastr fun!');
        console.log(data);
        this.candidato = new Candidato();
        this.gotoList();
      }, error => {
        console.log(error);
      });

  }
  onSubmit() {
    this.submitted = true;
    this.save();
  }
  gotoList() {
    this.router.navigate(['/candidato']);
  }
}
