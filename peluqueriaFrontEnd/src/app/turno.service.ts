import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class TurnoService {

  constructor(private http : HttpClient) { }

  getProduct(){
    this.http.get('https://api.npms.io/v2/search?q=scope:angular').subscribe((data) =>{
      console.log(data)
    })
  }
}
