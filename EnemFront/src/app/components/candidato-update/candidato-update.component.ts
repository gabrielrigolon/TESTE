import { Component, OnInit, TemplateRef } from '@angular/core';
import { Candidato } from '../../candidato.model';
import { ActivatedRoute, Router } from '@angular/router';
import { CandidatoServiceService } from '../../services/candidatoService.service';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-candidato-update',
  templateUrl: './candidato-update.component.html',
  styleUrls: ['./candidato-update.component.css']
})
export class CandidatoUpdateComponent implements OnInit {

  modalRef: BsModalRef;
  id: number;
  candidato: Candidato = new Candidato();

  constructor(private route: ActivatedRoute, 
    private router: Router,
              private candidatoService: CandidatoServiceService,
              private modalService: BsModalService) { }

  ngOnInit() {
    this.id = this.route.snapshot.params.id;
    this.candidatoService.get(this.id)
      .subscribe(data => {
        console.log(data);
        this.candidato = data;
      }, error => console.log(error));
  }

  public updateCandidato(): void {
    this.candidatoService.updateCandidato(this.id, this.candidato)
      .subscribe(data => {
        console.log(data);
        this.candidato = new Candidato();
        this.gotoList();
      }, error => console.log(error));
  }

  onSubmit() {
    this.modalRef.hide();
    this.updateCandidato();
  }

  gotoList() {
    this.router.navigate(['/candidatos']);
  }

  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template, {class: 'modal-sm'});
  }

  decline(): void {
    this.modalRef.hide();
  }
}
