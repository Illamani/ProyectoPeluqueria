import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TurnoComponent } from './turno/turno.component';

const routes: Routes = [
  {path: 'turno', component: TurnoComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
