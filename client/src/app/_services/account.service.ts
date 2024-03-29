import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  baseurl = 'https://localhost:7100/api/';

  constructor(private http: HttpClient) {   

  }

  login(model: any){
    return this.http.post(this.baseurl + 'account/login', model);
  }
}
