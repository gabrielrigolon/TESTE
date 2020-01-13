import { Component, OnInit, TemplateRef } from "@angular/core";
import { Observable } from "rxjs";
import { CandidatoServiceService } from '../../services/candidatoService.service';
import { Candidato } from "../../candidato.model";
import { Router } from "@angular/router";
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: "app-candidato-list",
  templateUrl: "./candidato-list.component.html",
  styleUrls: ["./candidato-list.component.css"]
})
export class CandidatoListComponent implements OnInit {
  responseUsers: Candidato[] = [];
  modalRef: BsModalRef;

  constructor(
    private candidatoService: CandidatoServiceService,
    private router: Router,
    private modalService: BsModalService
  ) {}

  ngOnInit() {
    this.reloadData();
  }

  reloadData() {
    this.candidatoService.getUsers().subscribe(response => {
      this.responseUsers = response;
    });
  }

  deleteCandidato(id: number) {
    this.candidatoService.deleteCandidato(id).subscribe(
      data => {
        console.log(data);
        this.modalRef.hide();
        this.reloadData();
      },
      error => console.log(error)
    );
  }

  get(id: number) {
    this.router.navigate(["details", id]);
  }

  detailsCandidato(id: number) {
    this.router.navigate(["details", id]);
  }

  updateCandidato(id: number) {
    this.router.navigate(["update", id]);
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
