import { Component, OnInit } from '@angular/core';
import { TurnoService, Turno } from '../../services/turno.service'

@Component({
  selector: 'app-add-edit-turno',
  templateUrl: './add-edit-turno.component.html',
  styleUrls: ['./add-edit-turno.component.css']
})
export class AddEditTurnoComponent implements OnInit {

  turno: Turno;
  constructor(private turnoService : TurnoService) { }

  ngOnInit(): void {
    this.turno = new Turno();
  }

  onSubmitAddTurno(){
    this.turnoService.insertTurnos(this.turno);
  }
}
