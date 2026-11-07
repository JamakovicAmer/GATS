import { Component, inject } from '@angular/core';
import { CurrentUserService } from '../../../core/services/auth/current-user.service';

/**
 * Home page for signed-in users who are not administrators (route /client).
 * Features for these users go here (and as new child routes in client-routing-module.ts).
 */
@Component({
  selector: 'app-client-home',
  standalone: false,
  templateUrl: './client-home.component.html',
  styleUrl: './client-home.component.scss',
})
export class ClientHomeComponent {
  protected currentUser = inject(CurrentUserService).currentUser;
}
