import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ShopComponent } from './shop/shop.component';
import { ItemCmpComponent } from './item-cmp/item-cmp.component';
import { PriceComponent } from './price/price.component';


const routes: Routes = [
  { path : '', component : ShopComponent, pathMatch: 'full'},
  { path : '', component : ItemCmpComponent, pathMatch: 'full' },
  { path : '', component : PriceComponent, pathMatch: 'full'},
  // { path: 'blogpost/:id', component: BlogPostComponent },
  // { path: 'add', component: BlogPostAddEditComponent },
  // { path: 'blogpost/edit/:id', component: BlogPostAddEditComponent },
  { path : ''},
  { path: '**', redirectTo: '/' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
