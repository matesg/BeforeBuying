import { Component, OnInit } from '@angular/core';
import { ShopService } from 'src/app/services/shop.service';
import { ActivatedRoute, Router} from '@angular/router';

@Component({
  selector: 'app-shop-details',
  templateUrl: './shop-details.component.html',
  styleUrls: ['./shop-details.component.css']
})
export class ShopDetailsComponent implements OnInit {
  currentShop = null;
  message = '';

  constructor(
    private shopService: ShopService,
    private route: ActivatedRoute,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.message = '';
    this.getShop(this.route.snapshot.paramMap.get('id'))
  }

  getShop(id) {
    this.shopService.get(id)
    .subscribe(
      data => {
        this.currentShop = data;
        console.log(data);
      },
      error => {
        console.log(error);
      });
  }

    updatePublished(status)
    {
      const data = {
        id : this.currentShop.id,
        name : this.currentShop.name,
        published: status
      };

      this.shopService.update(this.currentShop.id, data)
      .subscribe(
        response => {
          this.currentShop.published = status;
          console.log(response);
        },
        error => {
          console.log(error);
        });
      }

    updateShop(){
      this.shopService.update(this.currentShop.id, this.currentShop)
      .subscribe(
        response => {
          console.log(response);
          this.message = '';
        },
        error => {
          console.log(error);
        });
    }

    deleteShop(){
      this.shopService.delete(this.currentShop.id)
      .subscribe(
        response => {
          console.log(response);
          this.router.navigate(['/shops'])
          this.message = '';
        },
        error => {
          console.log(error);
        }
      )};
  
}
