import { Component, OnInit } from '@angular/core';
import { TurnoService } from '../turno.service'

@Component({
  selector: 'app-turno',
  templateUrl: './turno.component.html',
  styleUrls: ['./turno.component.css']
})
export class TurnoComponent implements OnInit {

  constructor(private turnoService : TurnoService) { }

  ngOnInit(): void {
    this.turnoService.getProduct();
  }

}
