import { Candidato } from "../../candidato.model";
import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { CandidatoServiceService } from "../../services/candidatoService.service";
import { ToastrService } from "ngx-toastr";
import { isNullOrUndefined } from "util";

@Component({
  selector: "app-candidato-create",
  templateUrl: "./candidato-create.component.html",
  styleUrls: ["./candidato-create.component.css"]
})
export class CandidatoCreateComponent implements OnInit {
  candidato: Candidato = new Candidato();
  submitted: boolean = false;

  constructor(
    private candidatoService: CandidatoServiceService,
    private router: Router,
    private toastr: ToastrService
  ) {}

  ngOnInit() {}

  public newCandidato(): void {
    this.submitted = false;
    this.candidato = new Candidato();
  }

  public save(): void {
    if (!isNullOrUndefined(this.candidato.nota)) {
      this.candidatoService.createCandidato(this.candidato).subscribe(
        data => {
          this.toastr.success("Candidato cadastrado!", "Sucesso!");
          this.candidato = new Candidato();
          this.gotoList();
          this.submitted = true;
        },
        error => {
          this.submitted = false;
          error.error.errors
            ? Object.values(error.error.errors).forEach(fieldErrors => {
                const errors = fieldErrors as Array<string>;
                errors.forEach(error => {
                  this.toastr.error(error);
                });
              })
            : this.toastr.warning(error.error);
        }
      );
    } else {
      this.submitted = false;
      this.toastr.error("A nota não foi preenchida");
      this.candidato.nota = 0;
    }
  }
  public onSubmit(): void {
    this.save();
  }
  private gotoList(): void {
    this.router.navigate(["/candidato"]);
  }
}
