import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class TodoService {
  constructor(private http: HttpClient) { }

  getTodos(): any {
    return this.http.get('/api/values');
  }

}
