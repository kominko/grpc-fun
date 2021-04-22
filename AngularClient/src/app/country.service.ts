import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CountryModel } from './models/country-model';
import { CountryClient, ServiceError } from './generated/country_pb_service';
import { CountriesReply, EmptyRequest } from './generated/country_pb';

@Injectable({
  providedIn: 'root'
})
export class CountryService {

  constructor(private http: HttpClient) { }

  getCountriesHttp(): Observable<CountryModel[]> {
    return this.http.get<CountryModel[]>("http://localhost:6001/Countries");
  }

  getCountriesGrpc(): Promise <CountryModel[]> {
    const client = new CountryClient('http://localhost:5001');
    return new Promise((resolve, reject) => {
      const req = new EmptyRequest();
      client.getAll(req, null, (err, response: CountriesReply) => {
        if (err) {
          return reject(err);
        }
        resolve(response.getCountriesList().map(x => <CountryModel>{
          id: x.getId(),
          name: x.getName(),
          description: x.getDescription()
        }));
      });
    });
  }
}
