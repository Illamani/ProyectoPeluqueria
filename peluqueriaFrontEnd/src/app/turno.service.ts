import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TurnoService {
  turno: Turno | null = null;

  constructor(private http : HttpClient) { }


  getProduct(): Observable<Turno>{
    return this.http.get<Turno>('https://localhost:44330/api/Turno/get-first-turno');
  }
}

interface Turno{
  id: number,
  apellido: string,
  fecha: string,
  tipoPeinado: string,
  nombre: string
}
