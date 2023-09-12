import { Component, OnInit } from '@angular/core';
import { TurnoService, Turno } from '../../services/turno.service'

@Component({
  selector: 'app-turno',
  templateUrl: './turno.component.html',
  styleUrls: ['./turno.component.css']
})
export class TurnoComponent implements OnInit {
  turno: Turno;
  turnosList : Turno[] = [];

  constructor(private turnoService : TurnoService) { }

  ngOnInit(): void {
    this.turnoService.getProduct().subscribe(response =>{
      this.turno = response;
    });
  }

  getTurnos(){
    this.turnoService.getTurnos().subscribe(response =>{
      this.turnosList = response;
      console.log(this.turnosList);
    })
  }
}