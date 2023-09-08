import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class TurnoService {

  constructor(private http : HttpClient) { }

  getProduct(){
    this.http.get('https://localhost:44330/api/Turno/get-turnos').subscribe((data) =>{
      console.log(data)
    })
  }
}
