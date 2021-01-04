import { Md5 } from 'ts-md5/dist/md5';
import { UserInfoService } from './../../service/UserInfo.service';
import { UserInfo } from './../../obj/UserInfo';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { isLogin } from 'src/app/function/myFunction';

@Component({
  selector: 'app-dangnhap',
  templateUrl: './dangnhap.component.html',
  styleUrls: ['./dangnhap.component.css']
})
export class DangnhapComponent implements OnInit {
  user = new UserInfo();
  existTelephone : boolean = true;
  wrongPassword: boolean;
  isValid : boolean;
  remember : boolean;
  telephoneInvalid : boolean;
  passwordInvalid : boolean;
  constructor(private service: UserInfoService, private router: Router) { }

  ngOnInit(): void {

  }

  Login(){
  //Kiểm tra tồn tại telephone
  this.service.getUserInfoByTelephone(this.user.telephone).subscribe((response : boolean) => {
    if(!response){
      this.existTelephone = false;
    }
    else{
      this.existTelephone = true;
      //Mã hóa mật khẩu
      let passEncrypted = Md5.hashStr(this.user.password);
      let token = Md5.hashStr(passEncrypted + this.user.telephone).toString();
      //end
      $('#login').text('Đang xử lý...');
      this.service.GetUserInfoByToken(token).subscribe((response : any) => {
        if(response == null){
          this.wrongPassword = true;
        }
        else{
          this.wrongPassword = false;
          this.isValid = true;
          this.user = response;
          if(this.remember == true){
            localStorage.removeItem('token');
            localStorage.setItem('token', token);
          }
          else{
            sessionStorage.removeItem('token');
            sessionStorage.setItem('token', token);
          }

          $('#login').text('Đăng nhập thành công, đang chuyển tiếp...');
          setTimeout(() => {
            window.location.reload();
          }, 2000);  //5s
          this.router.navigate(['/']);
        }
        });
      }
    });
  }
}
