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

  apiUrl : 'https://localhost:44330/api/Turno/'

  getFirstTurno(): Observable<Turno>{
    return this.http.get<Turno>('https://localhost:44330/api/Turno/get-first-turno');
  }

  getTurnos(): Observable<Turno[]>{
    return this.http.get<Turno[]>('https://localhost:44330/api/Turno/get-turnos');
  }

  insertTurnos(turno : Turno){
    console.log(turno)
    this.http.post('https://localhost:44330/api/Turno/insert-turno', turno).subscribe(
      (response) => {
        console.log('Solicitud exitosa:', response);
      },
      (error) => {
        console.error('Error en la solicitud:', error);
      }
    );
  }
}

export class Turno {
  id: number;
  apellido: string;
  fecha: Date;
  tipoPeinado: string;
  nombre: string ;
}