import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Todo } from './todo';

@Injectable()
export class TodoService {
  constructor(private http: HttpClient) { }

  getTodos(): any {
    console.log("todo.service.getTodos fired");
    return this.http.get('/api/todo');
  }

  addTodo(todo: Todo): any {
    console.log('todo.service.addTodo fired', todo.name);
    return this.http.post('/api/todo', todo);
  }
}
