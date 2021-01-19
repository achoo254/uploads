import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InphieuComponent } from './inphieu.component';

describe('InphieuComponent', () => {
  let component: InphieuComponent;
  let fixture: ComponentFixture<InphieuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InphieuComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InphieuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
