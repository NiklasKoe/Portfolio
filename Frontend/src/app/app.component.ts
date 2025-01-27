import { Component } from '@angular/core';
import { HubConnection, HubConnectionBuilder, LogLevel } from '@microsoft/signalr';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.scss'],
    standalone: false
})
export class AppComponent {
  title = 'frontend';

  private hubConnectionBuilder!: HubConnection;
  offers: any[] = [];

  /**
   *
   */
  constructor() {
  }

  ngOnInit() : void {
    this.hubConnectionBuilder = new HubConnectionBuilder()
      .withUrl('https://localhost:32768/offers')
      .configureLogging(LogLevel.Information)
      .build();
    this.hubConnectionBuilder
      .start()
      .then(() => console.log('Connection started.......!'))
      .catch(err => console.log('Error while connecting with server'));
    this.hubConnectionBuilder.on('SendOffersToUser', (result: any) => {
      this.offers.push(result);
    });
  }



  
}
