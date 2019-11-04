import { Component, OnInit, ChangeDetectionStrategy } from '@angular/core';

@Component({
  selector: 'app-monco',
  changeDetection: ChangeDetectionStrategy.OnPush,
  templateUrl: './monco.component.html',
  styleUrls: ['./monco.component.scss']
})
export class MoncoComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
