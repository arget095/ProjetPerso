import { Component } from '@angular/core';
import { NbMenuItem } from '@nebular/theme';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'projetangu';
  items: NbMenuItem[] = [
    {
      title: "profil",
      icon: 'people-outline',
      link: '/'
    },
    {
      title: "mes evenements",
      icon:'umbrella' ,
      link:'/'
    },
    {
      title: "categorie",
      icon:'list',
      link:'/'
    },
    {
      title:"paramètres",
      icon:'settings',
      link:'/'
    }
  ]
}
