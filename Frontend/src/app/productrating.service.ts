import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProductratingService {

  constructor(private http: HttpClient) { }

  public get() {
    return this.http.get<any[]>("https://localhost:32768/api/ratings")
  }
}
