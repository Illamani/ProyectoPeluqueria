import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {

  apiUrl : 'https://localhost:44330/api/Cliente/'
  constructor(private http : HttpClient) { }

  getFirstCliente(): Observable<Cliente>{
    return this.http.get<Cliente>('https://localhost:44330/api/Cliente/get-first-cliente');
  }

  getClientes(): Observable<Cliente[]>{
    return this.http.get<Cliente[]>('https://localhost:44330/api/Cliente/get-clientes');
  }

  insertCliente(cliente : Cliente){
    console.log(cliente)
    this.http.post('https://localhost:44330/api/Cliente/insert-cliente', cliente).subscribe(
      (response) => {
        console.log('Solicitud exitosa:', response);
      },
      (error) => {
        console.error('Error en la solicitud:', error);
      }
    );
  }

}

export class Cliente {
  id: number;
  nombre: string;
  apellido: string;
  fechaNacimiento: Date;
  sexo: boolean;
}