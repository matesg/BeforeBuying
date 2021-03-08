import { Component, OnInit } from '@angular/core';
import { ShopService } from 'src/app/services/shop.service';

@Component({
  selector: 'app-add-shop',
  templateUrl: './add-shop.component.html',
  styleUrls: ['./add-shop.component.css']
})
export class AddShopComponent implements OnInit {
  shop = {
    id: 0,
    name: 'Shop Name',
    published: false
  };
  submitted = false;

  constructor(private shopService: ShopService) { }

  ngOnInit(): void {
  }

  saveShop()
  {
    const data = {
      id: this.shop.id,
      name: this.shop.name
    };
    
    this.shopService.create(data)
      .subscribe(
        response => {
          console.log(response);
          this.submitted = true;
        },
        error => {
          console.log(error);
          this.submitted = false;
        }
      );
  }

  newShop(){
    this.submitted = false;
    this.shop = {
      id: 0,
      name: '',
      published: false
    }
  }

}
