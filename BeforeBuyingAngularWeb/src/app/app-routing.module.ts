import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ShopsListComponent } from './components/shops-list/shops-list.component';
import { ShopDetailsComponent } from './components/shop-details/shop-details.component';
import { AddShopComponent } from './components/add-shop/add-shop.component';

const routes: Routes = [
  { path: '', redirectTo: 'Shops', pathMatch: 'full' },
  { path: 'Shops', component: ShopsListComponent },
  { path: 'Shops/:id', component: ShopDetailsComponent },
  { path: 'add', component: AddShopComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
