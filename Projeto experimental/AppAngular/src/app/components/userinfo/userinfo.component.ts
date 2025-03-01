import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { NavbarComponent } from "../navbar/navbar.component";
import { SidebarComponent } from '../../pages/sidebar/sidebar.component';

@Component({
  selector: 'app-userinfo',
  standalone: true,
  imports: [CommonModule, NavbarComponent, RouterModule, SidebarComponent], 
  templateUrl: './userinfo.component.html',
  styleUrls: ['./userinfo.component.css']
})
export class UserinfoComponent { }
