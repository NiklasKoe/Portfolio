import { Component, OnInit } from '@angular/core';
import { ProductratingService } from '../../productrating.service';
import { firstValueFrom } from 'rxjs';

@Component({
    selector: 'app-productrating',
    templateUrl: './productrating.component.html',
    styleUrls: ['./productrating.component.scss'],
    standalone: false
})
export class ProductratingComponent implements OnInit {


  constructor(private ratingService: ProductratingService) {

  }

  public ratings: any[] = [];


  async ngOnInit() {
    //
    this.ratings = await firstValueFrom(this.ratingService.get());
  }

  
}
