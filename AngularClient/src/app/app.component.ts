import { Component, OnInit } from '@angular/core';
import { CountriesReply, EmptyRequest } from './generated/country_pb';
import { Country, CountryClient, ServiceError } from './generated/country_pb_service';
import { CountryModel } from './models/country-model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.sass']
})
export class AppComponent implements OnInit {
  title = 'angular-grpc';

  public countries: any;

  ngOnInit(): void {  }
}
