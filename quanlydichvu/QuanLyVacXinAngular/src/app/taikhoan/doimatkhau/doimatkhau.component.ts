import { NgForm } from '@angular/forms';
import { Md5 } from 'ts-md5/dist/md5';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserInfo } from 'src/app/obj/UserInfo';
import { UserInfoService } from 'src/app/service/UserInfo.service';
import { isLogin } from 'src/app/function/myFunction';

@Component({
  selector: 'app-doimatkhau',
  templateUrl: './doimatkhau.component.html',
  styleUrls: ['./doimatkhau.component.scss']
})
export class DoimatkhauComponent implements OnInit {
  user: UserInfo = new UserInfo();
  passwordNew : string;
  wrongPassword : boolean;
  isValid : boolean;
  constructor(private userInfoService: UserInfoService, private router: Router) { }

  ngOnInit() {
    //Kiểm tra đăng nhập hay chưa, nếu đã đăng nhập thì về trang chính
    if(!isLogin(this.user)){
      this.router.navigate(['/']);
    }else{
      this.userInfoService.GetUserInfoByToken(this.user.token).subscribe((data :UserInfo) => {
        this.user = data;
      });
    }
  }

  PutPassword(password : string, passwordNew : string){
    //Mã hóa mật khẩu cũ để kiểm tra mật khẩu cũ giống không, nếu giống thì cho phép đổi
    let passEncrypted = Md5.hashStr(password).toString();
    let token = Md5.hashStr(passEncrypted + this.user.telephone).toString();
    this.userInfoService.GetUserInfoByToken(token).subscribe((data :UserInfo) => {
      if(data == null){
        this.wrongPassword = true;
        this.isValid = false;
      }
      else{
        this.wrongPassword = false;
        this.user.password = Md5.hashStr(passwordNew).toString();
        this.user.token = Md5.hashStr(this.user.password + this.user.telephone).toString();
        this.userInfoService.PutPassword(this.user.userInfoId, this.user).subscribe((item :UserInfo) => {
          if(item != null){
            this.isValid = true;
            if(localStorage.getItem('token') != null){
              localStorage.removeItem('token');
              localStorage.setItem('token', this.user.token);
            }
            else{
              sessionStorage.removeItem('token');
              sessionStorage.setItem('token', this.user.token);
            }
          }
          else{
            this.isValid = false;
          }
        });
      }
    });
  }

}
