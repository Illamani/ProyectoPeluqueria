import { Component, OnInit } from '@angular/core';
import {  Turno } from '../../turno.service'

@Component({
  selector: 'app-add-edit-turno',
  templateUrl: './add-edit-turno.component.html',
  styleUrls: ['./add-edit-turno.component.css']
})
export class AddEditTurnoComponent implements OnInit {

  turno: Turno;
  constructor() { }

  ngOnInit(): void {
    this.turno = new Turno();
  }

  onSubmitAddTurno(){
    console.log(this.turno);
  }
}
