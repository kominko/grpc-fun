import { ThrowStmt } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { CountryService } from '../country.service';
import { CountriesReply, CountryReply, EmptyRequest } from '../generated/country_pb';
import { CountryClient, ServiceError } from '../generated/country_pb_service';
import { CountryModel } from '../models/country-model';

@Component({
  selector: 'app-countries',
  templateUrl: './countries.component.html',
  styleUrls: ['./countries.component.sass']
})
export class CountriesComponent implements OnInit {
  countriesGrpc: CountryModel[];
  countriesHttp: CountryModel[];
  constructor(private countryService: CountryService) { }

  ngOnInit(): void {
    this.getCountriesGrpc();
    this.getCountriesHttp();
  }

  private getCountriesGrpc(): void {
    const client = new CountryClient('https://localhost:5001');
    const req = new EmptyRequest();
    client.getAll(req, (err: ServiceError, response: CountriesReply) => {
      if (err) {
        console.log(err);
        return;
      }
      this.countriesGrpc = response.getCountriesList().map(x => <CountryModel>{
        id: x.getId(),
        name: x.getName(),
        description: x.getDescription()
      });
    });
  }

  private getCountriesHttp(): void {
    this.countryService.getCountriesHttp().subscribe(x => this.countriesHttp = x);
  }
}
