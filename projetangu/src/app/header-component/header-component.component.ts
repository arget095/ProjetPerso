import { Component, OnInit, ChangeDetectionStrategy} from '@angular/core';


@Component({
  selector: 'app-header-component',
  changeDetection: ChangeDetectionStrategy.OnPush,
  templateUrl: './header-component.component.html',
  styleUrls: ['./header-component.component.scss']
})
export class HeaderComponentComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
