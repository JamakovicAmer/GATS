import { Component, inject } from '@angular/core';
import { CurrentUserService } from '../../../../core/services/auth/current-user.service';

/**
 * Site header: logo, currency converter, currency selector, account menu.
 * Used by PublicLayoutComponent (/, /converter, ...) and ClientLayoutComponent (/client/...).
 */
@Component({
  selector: 'app-store-header',
  standalone: false,
  templateUrl: './store-header.component.html',
  styleUrl: './store-header.component.scss'
})
export class StoreHeaderComponent {
  protected currentUser = inject(CurrentUserService);
}
