import { Component, OnInit } from '@angular/core';
import { ShopService } from 'src/app/services/shop.service';

@Component({
  selector: 'app-shops-list',
  templateUrl: './shops-list.component.html',
  styleUrls: ['./shops-list.component.css']
})
export class ShopsListComponent implements OnInit {

  shops: any;
  currentShop = null;
  currentIndex = -1;
  name = '';

  constructor(private shopService : ShopService) { }

  ngOnInit(): void {
    
  }

  retrieveShops()
  {
    this.shopService.getAll()
      .subscribe(
        data => {
          this.shops =data;
          console.log(data);
        },
        error => {
          console.log(error);
        } 
      );
  }

  refreshList()
  {
    this.retrieveShops();
    this.currentShop = null;
    this.currentIndex = -1;
  }

  setActiveShop(shop, index)
  {
    this.currentIndex = index;
    this.currentShop = shop;
  }

  removeAllShops()
  {
    this.shopService.deleteAll()
      .subscribe(
        response => {
          console.log(response);
          this.retrieveShops();
        },
        error => {
          console.log(error);
        }
      );
  }

  searchName()
  {
    this.shopService.findByTitle(this.name)
      .subscribe(
        data => {
          this.shops = data;
          console.log(data);
        },
        error => {
          console.log(error);
        }
      );
  }
}
