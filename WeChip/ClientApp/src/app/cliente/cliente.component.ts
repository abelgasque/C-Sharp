import { Component, OnInit, Inject } from '@angular/core';
import { Cliente } from '../util/models';
import { UtilService } from '../util/util.service';

@Component({
  selector: 'app-cliente',
  templateUrl: './cliente.component.html',
  styleUrls: ['./cliente.component.css']
})
export class ClienteComponent implements OnInit {
  
  clientes: any[] = [];
  cliente = new Cliente();
  

  constructor(private util: UtilService) { }

  ngOnInit() {}

  gerenciarPersistencia(){
    if(this.cliente.id > 0){

    }else{
      this.salvarCliente();
    }
  }
  
  salvarCliente(){
    console.log(this.cliente);
    this.util.adicionarCliente(this.cliente).subscribe(
      (response: any) => {
        this.cliente = new Cliente();
      },
      (erro: any) => {
        console.log(erro);
      }
    );
  }

  carregarClientes(){
    this.util.getAllClientes().subscribe(
      (response: any) => {
        this.clientes =response;
      },
      (erro: any) => {
        console.log(erro);
      }
    );
  }

}
