import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ChatroomComponent } from './pages/chatroom/chatroom.component';
import { provideHttpClient, withInterceptorsFromDi } from '@angular/common/http';
import { LobbyComponent } from './pages/lobby/lobby.component';
import { ProductratingComponent } from './pages/productrating/productrating.component';
import { PersonalpageComponent } from './pages/personalpage/personalpage.component';
import { RouterModule, Routes } from '@angular/router';
import { NgxTypewriterComponent } from '@omnedia/ngx-typewriter';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';


const routes: Routes = [
  { path: 'lobby', component: LobbyComponent, data: { title: 'Loby' },  },
  { path: 'rooms/:roomId', component: ChatroomComponent, data: { title: 'Room' } },
  { path: 'products', component: ProductratingComponent, data: { title: 'Produkte' } },
  { path: 'rooms/:roomId', component: ChatroomComponent, data: { title: 'Room' } },
  { path: 'about/me', component: PersonalpageComponent, data: { title: 'Niklas' } },
];

@NgModule({ declarations: [
        AppComponent,
        ChatroomComponent,
        LobbyComponent,
        ProductratingComponent,
    ],
    bootstrap: [AppComponent], 
    imports: 
    [BrowserModule,
     RouterModule.forRoot(routes)], providers: [provideHttpClient(withInterceptorsFromDi()),
     NgxTypewriterComponent,
     FontAwesomeModule
    ] })
export class AppModule { }
