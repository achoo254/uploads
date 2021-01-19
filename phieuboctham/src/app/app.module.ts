import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NhaplieuComponent } from './nhaplieu/nhaplieu.component';
import { FormsModule } from '@angular/forms';
import { InphieuComponent } from './inphieu/inphieu.component';

@NgModule({
  declarations: [
    AppComponent,
    NhaplieuComponent,
    InphieuComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
