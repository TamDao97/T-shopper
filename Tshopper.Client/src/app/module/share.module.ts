import { NgModule } from '@angular/core';

import { LayoutComponent } from 'src/app/share/layout/layout.component';
import { HeaderComponent } from 'src/app/share/header/header.component';
import { FooterComponent } from '../share/footer/footer.component';
import { RouterModule } from '@angular/router';


@NgModule({
  declarations: [
    LayoutComponent,
    HeaderComponent,
    FooterComponent
  ],
  imports: [
    RouterModule
  ], exports: [
    LayoutComponent
  ]
})
export class ShareModule { }
