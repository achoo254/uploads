import { UserInfo } from './../obj/UserInfo';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-nhaplieu',
  templateUrl: './nhaplieu.component.html',
  styleUrls: ['./nhaplieu.component.css']
})
export class NhaplieuComponent implements OnInit {
  sobatdau : number;
  soketthuc : number;
  listNhanVien : UserInfo[] = [];
  userInfo  : UserInfo;

  constructor(private route : Router) { }

  ngOnInit(): void {
    console.log(this.listNhanVien);
  }
  fileUpload(files) {
    if (files && files.length > 0) {
        const file: File = files.item(0);
        const reader: FileReader = new FileReader();
        reader.readAsText(file);
        reader.onload = (e) => {
            const res = reader.result as string; // This variable contains your file as text
            const lines = res.split('\n'); // Splits you file into lines
            lines.forEach((line) => {
              this.userInfo = new UserInfo();
              this.userInfo.sobaodanh = line.split(',')[0];
              this.userInfo.hoten = line.split(',')[1];
              this.listNhanVien.push(this.userInfo); // Get first item of line
            });
            console.log(this.listNhanVien);
        };
    }
}
sendData(){
  this.route.navigate(['/inphieu', JSON.stringify(this.listNhanVien)]);
}
}
