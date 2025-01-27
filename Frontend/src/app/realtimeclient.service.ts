import { Injectable } from '@angular/core';
import { Observable, Subject } from 'rxjs';
import { Order } from './data';

@Injectable({
  providedIn: 'root'
})
export class RealtimeclientService {

  // private hubConnection: signalR.HubConnection;
  // private pendingFoodUpdatedSubject = new Subject<Order[]>();
  // ordersUpdated$: Observable<Order[]> = this.pendingFoodUpdatedSubject.asObservable();

  constructor() {
    // this.hubConnection = new SpeechRecognitionAlternative.HubConnectionBuilder().withUrl("http://localhost:4200/")
   }
}
