import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Chatroom } from './data';

@Injectable({
  providedIn: 'root'
})
export class ChatroomService {

  constructor(private http: HttpClient) { }

  public create() {
    //
    let cr = new Chatroom();
    // cr.id = this.generateGUID();
    cr.name = "erster Chatroom";
    //
    // const headers = new HttpHeaders().set('Content-Type', 'text/plain; charset=utf-8');
    //
    return this.http.post<Chatroom>("https://localhost:32768/api/chatroom", cr ); // , { headers: headers, responseType}
  }



  // private generateGUID(): string {
  //   return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function(c) {
  //   var r = Math.random() * 16 | 0,
  //   v = c === 'x' ? r : (r & 0x3 | 0x8);
  //   return v.toString(16);
  //   });
  //   }

}
