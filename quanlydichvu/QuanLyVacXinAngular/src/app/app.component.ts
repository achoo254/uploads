import { ProductService } from './service/Product.service';
import { Notify } from './obj/Notify';
import { UserInfoService } from './service/UserInfo.service';
import { RegimenService } from './service/Regimen.service';
import { CategoriesService } from './service/Categories.service';
import { UserInfo } from './obj/UserInfo';
import { Router } from '@angular/router';
import { Component, OnInit, TemplateRef } from '@angular/core';
import { CustomerService } from './service/Customer.service';
import { Customer } from './obj/Customer';
import { NotifyService } from './service/Notify.service';
import { Product } from './obj/Product';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  listRegimen  : Object;
  listCategories : Object;
  listNotify : Notify[] = [];
  listProduct : Product[] = [];
  product : Product = new Product();
  countNotify : number = 0;
  user : UserInfo = new UserInfo();
  isLogin : boolean;
  customerId : number;
  modalRefResultSearch: BsModalRef;
  constructor(private modalService: BsModalService, private productService : ProductService, private notifyService: NotifyService, private customerService: CustomerService, private categoriesService: CategoriesService, private regimenService: RegimenService, private userInfoService: UserInfoService, private router: Router){}

  ngOnInit(): void {
    this.GetAllRegimen();
    this.GetAllCategories();
    this.GetUserLogin();
    setTimeout(() => {
      this.GetAllNotify();
      this.LichSuTiem();
    }, 3000);  //5s
  }

  GetUserLogin(){
    if(localStorage.getItem('token') != null){
      this.user.token = localStorage.getItem('token');
    }
    else if(sessionStorage.getItem('token') != null ){
      this.user.token = sessionStorage.getItem('token');
    }
    this.userInfoService.GetUserInfoByToken(this.user.token).subscribe((data : UserInfo) => {
      if(data != null){
        this.isLogin = true;
        this.user = data;
      }
    });
  }

  UserLogout(){
    $('#closeLogout').click();
    localStorage.removeItem('token');
    sessionStorage.removeItem('token');
    this.user = null;
    this.isLogin = false;
    window.location.reload();
  }

  GetAllRegimen(){
    this.regimenService.GetAllRegimen().subscribe(data => {
      this.listRegimen = data;
    });
  }

  GetAllCategories(){
    this.categoriesService.GetAllCategories().subscribe(data => {
      this.listCategories = data;
    });
  }

  GetAllNotify(){
    //Lấy thông tin customer theo UserInfo
    if(this.user.userInfoId != undefined){
      this.customerService.GetCustomerByUserInfo(this.user.userInfoId).subscribe((customer : Customer) => {
        if(customer != null){
          this.listNotify = [];
          customer.listNotify.forEach(item =>{
            this.listNotify.push(item);
            if(item.status == false){
              this.countNotify++;
            }
          });
          this.listNotify.reverse();
        }
      });
    }
  }

  ReadNotify(listNotify: Notify[]){
    if(listNotify.length > 0){
      listNotify.forEach(item =>{
        if(item.status == false){
          item.status = true;
          this.notifyService.PutNotify(item.notifyId, item).subscribe((notify : any) => {
            if(notify != null){
              this.countNotify--;
            }
          });
        }
      });
    }
  }

  LichSuTiem(){
    if(this.user.userInfoId != undefined){
      this.customerService.GetCustomerByUserInfo(this.user.userInfoId).subscribe((data : Customer) => {
        if(data != null){
          this.customerId = data.customerId;
        }
      });
    }
  }

  TimKiemSanPham(templateRef: TemplateRef<any>){
    if(this.product.name != ''){
      this.productService.GetAllProduct().subscribe((data : Product[]) => {
        data.forEach(item=>{
          if(item.name.indexOf(this.product.name) > -1){
            this.modalRefResultSearch = this.modalService.show(templateRef, { id: 1, class: 'modal-sm' });
            this.openCloseModalAutoSubmit(1);
            setTimeout(()=>{
              this.router.navigate(['/product/'+item.productId]);
              }, 2000);
          }
        });
      });
    }
  }

  openCloseModalAutoSubmit(templateId : number){
    setTimeout(()=>{
      this.modalService.hide(templateId);
  }, 2000);
  }
}
