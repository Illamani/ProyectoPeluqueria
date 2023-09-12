import { Component, OnInit } from '@angular/core';
import { ClienteService, Cliente} from 'src/app/services/cliente.service';
@Component({
  selector: 'app-add-edit-clientes',
  templateUrl: './add-edit-clientes.component.html',
  styleUrls: ['./add-edit-clientes.component.css']
})
export class AddEditClientesComponent implements OnInit {

  cliente : Cliente;
  constructor(private clienteService: ClienteService) { }

  ngOnInit(): void {
    this.cliente = new Cliente();
  }
  onSubmitAddCliente(){
    this.clienteService.insertCliente(this.cliente);
  }
}
