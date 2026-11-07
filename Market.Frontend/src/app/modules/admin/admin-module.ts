import {NgModule} from '@angular/core';

import {AdminRoutingModule} from './admin-routing-module';
import {AdminLayoutComponent} from './admin-layout/admin-layout.component';
import {SharedModule} from '../shared/shared-module';
import {AdminHomeComponent} from './admin-home/admin-home.component';


@NgModule({
  declarations: [
    AdminLayoutComponent,
    AdminHomeComponent,
  ],
  imports: [
    AdminRoutingModule,
    SharedModule,
  ]
})
export class AdminModule { }
