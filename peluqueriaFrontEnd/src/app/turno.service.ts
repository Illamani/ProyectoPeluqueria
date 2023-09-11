import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class TurnoService {
  turno: Observable<Turno> | null = null;
  turnosList: Turno[] = [];
  constructor(private http : HttpClient) { }


  getProduct(): Observable<Turno>{
    return this.http.get<Turno>('https://localhost:44330/api/Turno/get-first-turno');
  }

  getTurnos(): Observable<Turno[]>{
    return this.http.get<Turno[]>('https://localhost:44330/api/Turno/get-turnos');
  }
}

// export interface Turno{
//   id: number,
//   apellido: string,
//   fecha: Date,
//   tipoPeinado: string,
//   nombre: string
// }

export class Turno {
  id: number;
  apellido: string;
  fecha: Date;
  tipoPeinado: string;
  nombre: string ;
}