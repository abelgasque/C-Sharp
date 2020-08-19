import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.css']
})
export class ClientesComponent implements OnInit {

  clientes: any[] = [];

  constructor() { }

  ngOnInit() {
  }

}

export interface Cliente {
  nome: string;
  telefone: string;
  credito: number;
}