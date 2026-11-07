import { Component, inject } from '@angular/core';
import { CurrentUserService } from '../../../core/services/auth/current-user.service';

/**
 * Landing page of the public part of the application.
 * Route: '' inside PublicLayoutComponent (see public-routing-module.ts).
 */
@Component({
  selector: 'app-landing',
  standalone: false,
  templateUrl: './landing.component.html',
  styleUrl: './landing.component.scss',
})
export class LandingComponent {
  protected currentUser = inject(CurrentUserService);
}
