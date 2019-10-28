import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MoncoComponent } from './monco.component';

describe('MoncoComponent', () => {
  let component: MoncoComponent;
  let fixture: ComponentFixture<MoncoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MoncoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MoncoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
