import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AdminLayoutComponent } from './admin-layout/admin-layout.component';
import {MyProfileComponent} from '../account/my-profile/my-profile.component';
import {AdminSettingsComponent} from './admin-settings/admin-settings.component';
import {ExchangeRatesComponent} from './finance/exchange-rates/exchange-rates.component';

const routes: Routes = [
  {
    path: '',
    component: AdminLayoutComponent,
    children: [
      // FINANCE
      {
        path: 'exchange-rates',
        component: ExchangeRatesComponent,
      },

      // APPLICATION SETTINGS (empty page – the application settings go here)
      {
        path: 'settings',
        component: AdminSettingsComponent,
      },

      // MY PROFILE (same page as /client/profile, declared in AccountModule)
      {
        path: 'profile',
        component: MyProfileComponent,
      },

      // default admin route → /admin/exchange-rates
      {
        path: '',
        redirectTo: 'exchange-rates',
        pathMatch: 'full',
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AdminRoutingModule {}
