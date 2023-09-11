import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TurnoComponent } from './turno/turno.component';
import { AddEditTurnoComponent } from './turno/add-edit-turno/add-edit-turno.component';

const routes: Routes = [
  {path: 'turno', component: TurnoComponent},
  {path: 'turnoEdit', component: AddEditTurnoComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
