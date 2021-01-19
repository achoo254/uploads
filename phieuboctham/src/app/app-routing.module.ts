import { InphieuComponent } from './inphieu/inphieu.component';
import { NhaplieuComponent } from './nhaplieu/nhaplieu.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {path: 'nhaplieu', component:NhaplieuComponent },
  {path: 'inphieu/:listNhanVien', component:InphieuComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
