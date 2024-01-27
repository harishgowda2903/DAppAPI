import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core'; 

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Dating App';
  users: any;

  constructor(private http: HttpClient) {
    this.http.get("https://localhost:7100/api/Users").subscribe(
      {
        next: result => this.users = result,
        error: error => console.log(error),
        complete: () => console.log("Request has completed!")
        
      } 
    )

  }
}
