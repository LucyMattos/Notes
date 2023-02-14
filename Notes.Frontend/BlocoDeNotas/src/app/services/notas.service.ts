import { Notas } from './../models/notas.model';
import { BaseService } from './base.service';
import { Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';

@Injectable({
    providedIn: 'root'
})

export class NotasService extends BaseService {
    constructor(http: HttpClient) {
        super(http);
    }

    obterNotas() {
        return this._get<Notas[]>(`https://localhost:7133/notes`);
    }

    obterNotasPorId(id: number) {
        return this._get<Notas[]>(`https://localhost:7133/notes/${id}`);
    }

    adicionarNota(nota: Notas){
        return this._post<Notas[]>(`https://localhost:7133/notes`, nota);
    }

    editarNota(id: number){
        return this._put<Notas[]>(`https://localhost:7133/notes`, id);
    }

    excluirNota(id: number){
        return this._delete<Notas[]>(`https://localhost:7133/notes/${id}`);
    }
}