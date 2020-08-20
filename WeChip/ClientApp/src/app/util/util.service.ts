import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class UtilService {

  urlCliente = `${environment.apiUrl}/api/cliente`;

  constructor(private http: HttpClient) { }

  adicionarCliente(entidade: any): Observable<any>{
    return this.http.post<any>(`${this.urlCliente}`, entidade);
  }

  atualizarCliente(entidade: any): Observable<any>{
    return this.http.put<any>(`${this.urlCliente}`, entidade);
  }

  // getClientById(entidade: number): Observable<any>{
  //   return this.http.put<any>(this.urlCliente, entidade);
  // }

  getAllClientes(): Observable<any[]>{
    return this.http.get<any>(this.urlCliente);
  }
}
