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
  adicionarNotaForm! : FormGroup;

  nota: Notas[] = [];

constructor(private router: Router,
            private fb: FormBuilder){}

              
ngOnInit(): void {
    this.createForm();
  }

createForm(): void{
this.adicionarNotaForm = this.fb.group({
  titulo: ['', [Validators.required]],
  descricao: ['', [Validators.required]]
});
}

salvar(){
if(this.adicionarNotaForm.valid)
return
}

cancelar(){
  this.adicionarNotaForm.reset();
}
}