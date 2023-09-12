import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TurnoComponent } from './turno/mostrar-turno/turno.component';
import { AddEditTurnoComponent } from './turno/add-edit-turno/add-edit-turno.component';
import { AddEditClientesComponent } from './clientes/add-edit-clientes/add-edit-clientes.component';
import { ViewClientesComponent } from './clientes/view-clientes/view-clientes.component';

const routes: Routes = [
  {path: 'turno', component: TurnoComponent},
  {path: 'turnoEdit', component: AddEditTurnoComponent},
  {path: 'clienteEdit', component: AddEditClientesComponent},
  {path: 'cliente', component: ViewClientesComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
