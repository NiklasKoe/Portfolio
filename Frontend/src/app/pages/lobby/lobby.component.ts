import { Component } from '@angular/core';
import { firstValueFrom } from 'rxjs';
import { ChatroomService } from '../../chatroom.service';
import { Router } from '@angular/router';

@Component({
    selector: 'app-lobby',
    templateUrl: './lobby.component.html',
    styleUrls: ['./lobby.component.scss'],
    standalone: false
})
export class LobbyComponent {


  constructor(private chatroomService: ChatroomService, private router: Router) {
  }

  async createChatroom() {
    //
    let room = await firstValueFrom(this.chatroomService.create());
    //
    console.log(room);
    //
    this.router.navigate(["rooms", room.id]);
  }

}
