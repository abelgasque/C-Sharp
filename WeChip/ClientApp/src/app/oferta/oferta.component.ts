import { Component, OnInit } from '@angular/core';
import { UtilService } from '../util/util.service';

@Component({
  selector: 'app-oferta',
  templateUrl: './oferta.component.html',
  styleUrls: ['./oferta.component.css']
})
export class OfertaComponent implements OnInit {

  listaProdutos: any[] = [];
  listaStatus:any[] = [];

  constructor(private util: UtilService) { }

  ngOnInit() {
    this.carregarClientes();
  }

   carregarClientes(){
    this.util.getAllClientes().subscribe(
      (response: any) => {
        this.listaProdutos =response;
      },
      (erro: any) => {
        console.log(erro);
      }
    );
  }

}
