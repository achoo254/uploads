import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { isLogin } from '../function/myFunction';
import { UserInfo } from '../obj/UserInfo';
import { UserInfoService } from '../service/UserInfo.service';

@Component({
  selector: 'app-taikhoan',
  templateUrl: './taikhoan.component.html',
  styleUrls: ['./taikhoan.component.css']
})
export class TaikhoanComponent implements OnInit {
  user: UserInfo = new UserInfo();
  constructor(private userInfoService: UserInfoService, private router: Router) { }

  ngOnInit(): void {
    if(sessionStorage.getItem('token') == null && localStorage.getItem('token') == null){
      this.router.navigate(['/dangnhap/']);
    }
    else if(sessionStorage.getItem('token') != null){
      this.user.token = sessionStorage.getItem('token');
    }
    else if(localStorage.getItem('token') != null){
      this.user.token = localStorage.getItem('token');
    }
    this.userInfoService.GetUserInfoByToken(this.user.token).subscribe((data :UserInfo) => {
      this.user = data;
    });
  }

  PutInfoUser(){
    this.userInfoService.PutUserInfo(this.user.userInfoId, this.user).subscribe((data :UserInfo) => {

    });
  }

}
