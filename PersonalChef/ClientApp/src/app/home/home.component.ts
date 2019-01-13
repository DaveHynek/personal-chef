import { Component, OnInit } from '@angular/core';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.sass']
})
@Injectable()
export class HomeComponent implements OnInit {
    config: any[];
    config2: any[];

    constructor(private http: HttpClient) {
        this.http.get('api/sampledata/weatherforecasts').subscribe((data: any[]) => this.config = data);
        this.http.get('api/units').subscribe((data: any[]) => this.config2 = data);
    }

  ngOnInit() {
  }

}
