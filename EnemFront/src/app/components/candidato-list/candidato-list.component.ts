import { Component, OnInit, TemplateRef } from "@angular/core";
import { Observable } from "rxjs";
import { CandidatoServiceService } from '../../services/candidato.service';
import { Candidato } from "../../models/candidato.model";
import { Router } from "@angular/router";
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: "app-candidato-list",
  templateUrl: "./candidato-list.component.html",
  styleUrls: ["./candidato-list.component.css"]
})
export class CandidatoListComponent implements OnInit {
  candidatos: Candidato[] = [];
  modalRef: BsModalRef;

  constructor(
    private candidatoService: CandidatoServiceService,
    private router: Router,
    private modalService: BsModalService
  ) {}

  ngOnInit() {
    this.reloadData();
  }

  public reloadData(): void {
    this.candidatoService.getUsers().subscribe(response => {
      this.candidatos = response;
    });
  }

  public deleteCandidato(id: number): void {
    this.candidatoService.deleteCandidato(id).subscribe(
      data => {
        console.log(data);
        this.modalRef.hide();
        this.reloadData();
      },
      error => console.log(error)
    );
  }

  public get(id: number): void {
    this.router.navigate(["details", id]);
  }

  public detailsCandidato(id: number): void {
    this.router.navigate(["details", id]);
  }

  public updateCandidato(id: number): void {
    this.router.navigate(["update", id]);
  }
 
 


  public openModal(template: TemplateRef<any>): void {
    this.modalRef = this.modalService.show(template, {class: 'modal-sm'});
  }

  public decline(): void {
    this.modalRef.hide();
  }

}
