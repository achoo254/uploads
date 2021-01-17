/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { PhongComponent } from './phong.component';

describe('PhongComponent', () => {
  let component: PhongComponent;
  let fixture: ComponentFixture<PhongComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PhongComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PhongComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
