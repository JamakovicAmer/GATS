import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClientLayoutComponent } from './client-layout/client-layout.component';
import { ClientHomeComponent } from './client-home/client-home.component';
import { MyProfileComponent } from '../account/my-profile/my-profile.component';

// Routes under /client (guard in app-routing-module.ts: any signed-in user)
const routes: Routes = [
  {
    path: '',
    component: ClientLayoutComponent,
    children: [
      // default → /client
      { path: '', component: ClientHomeComponent, pathMatch: 'full' },
      // same page as /admin/profile (declared in AccountModule)
      { path: 'profile', component: MyProfileComponent },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ClientRoutingModule { }
