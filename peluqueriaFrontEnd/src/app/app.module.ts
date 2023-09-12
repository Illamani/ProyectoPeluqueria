import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TurnoComponent } from './turno/mostrar-turno/turno.component';
import { RouterModule } from '@angular/router';
import { AddEditTurnoComponent } from './turno/add-edit-turno/add-edit-turno.component';
import { FormsModule } from '@angular/forms';
import { ViewClientesComponent } from './clientes/view-clientes/view-clientes.component';
import { AddEditClientesComponent } from './clientes/add-edit-clientes/add-edit-clientes.component';
@NgModule({
  declarations: [
    AppComponent,
    TurnoComponent,
    AddEditTurnoComponent,
    ViewClientesComponent,
    AddEditClientesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    RouterModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
