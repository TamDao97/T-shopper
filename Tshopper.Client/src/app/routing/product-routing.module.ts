import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CartComponent } from '../product/cart/cart.component';
import { CheckoutComponent } from '../product/checkout/checkout.component';
import { ProductDetailComponent } from '../product/product-detail/product-detail.component';
import { ProductComponent } from '../product/product/product.component';

const routes: Routes = [
  {
    path: '',
    component: ProductComponent
  },
  {
    path: 'detail',
    component: ProductDetailComponent
  },
  {
    path: 'cart',
    component: CartComponent
  },
  {
    path: 'checkout',
    component: CheckoutComponent
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProductRoutingModule { }
