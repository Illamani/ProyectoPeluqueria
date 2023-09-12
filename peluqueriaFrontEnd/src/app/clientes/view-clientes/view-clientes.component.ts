import { Component, OnInit } from '@angular/core';
import { Cliente, ClienteService } from 'src/app/services/cliente.service';

@Component({
  selector: 'app-view-clientes',
  templateUrl: './view-clientes.component.html',
  styleUrls: ['./view-clientes.component.css']
})
export class ViewClientesComponent implements OnInit {
  cliente : Cliente;
  clienteList : Cliente[];
  constructor(private clienteService : ClienteService) {
    this.cliente = new Cliente();
  }

  ngOnInit(): void {
  }
  getClientes(){
      this.clienteService.getClientes().subscribe(response =>{
        this.clienteList = response;
        console.log(this.clienteList);
      })
  }
}
