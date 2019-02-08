import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { AppService } from './app.service';
import { HttpClientModule } from '@angular/common/http';

import { CommonModule } from '@angular/common';

import { DropdownModule } from 'angular-dropdown-component';
import { NumberOnlyDirective } from './directives/numbers';

@NgModule({
  declarations: [
    AppComponent,
    NumberOnlyDirective
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CommonModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule,
    TooltipModule.forRoot(),
    DropdownModule
  ],
  providers: [AppService],
  bootstrap: [AppComponent]
})
export class AppModule { }
