import { Component, OnInit } from '@angular/core'
import { CountryService } from '../country.service'
import { CountryModel } from '../models/country-model'

@Component({
  selector: 'app-countries',
  templateUrl: './countries.component.html',
  styleUrls: ['./countries.component.sass'],
})
export class CountriesComponent implements OnInit {
  countriesGrpc: CountryModel[]
  countriesHttp: CountryModel[]
  constructor(private countryService: CountryService) {}

  ngOnInit(): void {  }

  loadGrpc(): void {
    this.countryService.getCountriesGrpc().then(x => (this.countriesGrpc = x))
  }

  loadHttp(): void {
    this.countryService.getCountriesHttp().subscribe(x => (this.countriesHttp = x))
  }
}
