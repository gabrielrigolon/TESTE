import { Component, OnInit } from '@angular/core';
import { CandidatoServiceService } from '../../services/candidato.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-candidato-calculate',
  templateUrl: './candidato-calculate.component.html',
  styleUrls: ['./candidato-calculate.component.css']
})
export class CandidatoCalculateComponent implements OnInit {

  numVagas: any;

  constructor(
    private candidatoService: CandidatoServiceService,
    private router: Router) { }
  

  ngOnInit() {
  }

  public exibirResultados(): void {
    this.candidatoService.exibirResultados(this.numVagas).subscribe(data => {
      console.log(data);
      this.router.navigate(['candidato']);
    }, error => {
      console.log(error);
    });
  }

  public cancel(): void {
    this.router.navigate(['candidato']);
  }
}
