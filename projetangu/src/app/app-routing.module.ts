import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MoncoComponent } from './monco/monco.component';


const routes: Routes = [
  {
    path:'',
    component: MoncoComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
