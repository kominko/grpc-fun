import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CountryModel } from './models/country-model';

@Injectable({
  providedIn: 'root'
})
export class CountryService {

  constructor(private http: HttpClient) { }

  getCountriesHttp(): Observable<CountryModel[]> {
    return this.http.get<CountryModel[]>("https://localhost:6001/Countries");
  }
}
