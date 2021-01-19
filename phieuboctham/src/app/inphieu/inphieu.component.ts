import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { UserInfo } from '../obj/UserInfo';

@Component({
  selector: 'app-inphieu',
  templateUrl: './inphieu.component.html',
  styleUrls: ['./inphieu.component.css']
})
export class InphieuComponent implements OnInit {
  listNhanVien: UserInfo[] = JSON.parse(this.dataRoute.snapshot.params['listNhanVien']);
  constructor(private dataRoute: ActivatedRoute) { }

  ngOnInit(): void {
  }

}
