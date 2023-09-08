import { Component, OnInit } from '@angular/core';
import { TurnoService } from '../turno.service'

@Component({
  selector: 'app-turno',
  templateUrl: './turno.component.html',
  styleUrls: ['./turno.component.css']
})
export class TurnoComponent implements OnInit {
  turno: Turno | null = null;

  constructor(private turnoService : TurnoService) { }

  ngOnInit(): void {
    this.turno = this.turnoService.getProduct();
  }
}

interface Turno{
  id: number,
  apellido: string,
  fecha: string,
  tipoPeinado: string,
  nombre: string
}