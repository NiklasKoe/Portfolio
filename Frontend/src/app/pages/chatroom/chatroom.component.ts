import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HubConnection, HubConnectionBuilder, LogLevel } from '@microsoft/signalr';

@Component({
    selector: 'app-chatroom',
    templateUrl: './chatroom.component.html',
    styleUrls: ['./chatroom.component.scss'],
    standalone: false
})
export class ChatroomComponent {

  /**
   *
   */
  constructor(private activatedRoute: ActivatedRoute) {


  }


  private hubConnectionBuilder!: HubConnection;
  offers: any[] = [{
    "text": "Hallo ich bins!",
    "userId": 1,
    "chatId": "a758954a-8e7d-424b-b17f-c74865dcd9fd"
  },
  {
    "text": "Hallo du ists!",
    "userId": 2,
    "chatId": "a758954a-8e7d-424b-b17f-c74865dcd9fd"
  }];

  async ngOnInit() {
    //
    let chatroomId = this.activatedRoute.snapshot.paramMap.get('roomId')!;
    //
    this.hubConnectionBuilder = new HubConnectionBuilder()
      .withUrl('https://localhost:32768/chat')
      .configureLogging(LogLevel.Information)
      .build();
    this.hubConnectionBuilder
      .start()
      .then(() => console.log('Connection started.......!'))
      .catch(err => console.log('Error while connecting with server'));
    this.hubConnectionBuilder.on('SendMessageToChatroom', (result: any) => {
      //
      if (result.chatId == chatroomId) {
        this.offers.push(result);
      }
      // this.offers.push(result);

    });
  }

}
