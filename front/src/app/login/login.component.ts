import { Component, OnInit } from '@angular/core';
import axios from 'axios';
import { Route, Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit(): void {
  }
  login(){
    let edv = document.getElementById("EDV") as HTMLInputElement;
    let password = document.getElementById("password") as HTMLInputElement;

    var data = JSON.stringify({
      "edv": edv?.value,
      "password": password?.value
    });

    let self = this;
    var config = {
      method: 'post',
      url: 'http://localhost:5051/user/login',
      headers: { 
        'Content-Type': 'application/json'
      },
      data : data
    };

    axios(config)
    .then(function (response:any) {
      localStorage.setItem('authToken',response.data);
      self.router.navigate(['home']);
    })
    .catch(function (error:any) {
      console.log(error);
    });

  }
}
