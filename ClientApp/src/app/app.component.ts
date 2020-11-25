import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Atomic Sped app';
  public isDarkTheme = true;

  toggleTheme() {
    this.isDarkTheme = !this.isDarkTheme;
  }
}
