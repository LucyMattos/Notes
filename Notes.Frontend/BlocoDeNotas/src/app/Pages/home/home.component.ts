import { NotasService } from './../../services/notas.service';
import { Notas } from './../../models/notas.model';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  adicionarNotaForm!: FormGroup;

  nota: Notas[] = [];
  notaExclusao!: Notas;

  constructor(private router: Router,
    private fb: FormBuilder,
    private notasService: NotasService) { }


  ngOnInit(): void {
    this.createForm();
    this.buscarNotas();
  }

  createForm(): void {
    this.adicionarNotaForm = this.fb.group({
      id: [''],
      titulo: ['', [Validators.required]],
      descricao: ['', [Validators.required]]
    });
  }

  salvar() {
    if (this.adicionarNotaForm.invalid) {
      this.adicionarNotaForm.markAsTouched();
      return;
    }

    const formNota = this.adicionarNotaForm.getRawValue();
    const oSalvar = formNota.id > 0 ? this.notasService.editarNota(formNota) : this.notasService.adicionarNota(formNota)

    oSalvar.subscribe(() => {
      this.cancelar();
    });
  }

  cancelar() {
    this.adicionarNotaForm.reset();
    this.buscarNotas();
  }

  buscarNotas() {
    this.notasService.obterNotas().subscribe(result => {
      this.nota = result;
    })
  }

  editarNota(item: Notas) {
    this.adicionarNotaForm.patchValue(item);
  }

  excluirNota(id: number) {
    this.notasService.excluirNota(id).subscribe(() => {
      this.buscarNotas();
    });
  }

  excluir(item: Notas) {
    this.notaExclusao = item
  }

}
