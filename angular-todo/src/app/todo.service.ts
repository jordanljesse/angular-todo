import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Todo } from './todo';

@Injectable()
export class TodoService {
  constructor(private http: HttpClient) { }

  getTodos(): any {
    return this.http.get('/api/todo');
  }

  addTodo(todo: Todo): any {
    console.log('todo sent!', todo.name);
    return this.http.post('/api/todo', todo);
  }
}
