import { Component, OnInit,AfterViewInit } from '@angular/core';
import { TurnoService } from './services/turno.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  constructor(private turnoService : TurnoService) { }
  ngOnInit(): void {  
  }
  title = 'peluqueriaFrontEnd';
  
}
