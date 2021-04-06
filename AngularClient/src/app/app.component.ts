import { Component, OnInit } from '@angular/core';
import { CountriesReply, EmptyRequest } from './generated/country_pb';
import { Country, CountryClient } from './generated/country_pb_service';
import { CountryModel } from './models/country-model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.sass']
})
export class AppComponent implements OnInit {
  title = 'angular-grpc';

  public countries: CountryModel[] = [];
  public client = new CountryClient('http://localhost:5000');



  ngOnInit(): void {

    // client.getAll(req, null, (err, response: CountriesReply) => {
    //   if (err) return;
    //   let result = response.toObject();
    //   console.log(result);
    //   result.countriesList.map(country =>
    //     <Country>({
    //       name: country.name,
    //       description: country.description
    //     }));
    // });

    this.getAll().then(x => this.countries = x);

    console.log(this.countries);
  }


  getAll(): Promise <any> {
    return new Promise((resolve, reject) => {
      const req = new EmptyRequest();
      this.client.getAll(req, null, (err, response: CountriesReply) => {
        if (err) {
          return reject(err);
        }
        resolve(x => {
          let result = response.toObject()
          return result.countriesList.map(c => {
            <CountryModel>({
              name: c.name,
              description: c.description
            })
          })
        });
      });
    });
  }


}
