import { Component, OnInit } from '@angular/core';

import { Observable } from 'rxjs/Observable';
import { TodoService } from '../../todo.service';
import { Todo } from '../../todo';

@Component({
  selector: 'app-todos',
  templateUrl: './todos.component.html',
  styleUrls: ['./todos.component.css']
})

export class TodosComponent implements OnInit {
  constructor(private todoService: TodoService) { }

  todos: Todo[];
  todo: Todo = {
    id: 0,
    name: ""
  };

  ngOnInit() {
    this.getTodos();
  }

  getTodos() {
    this.todoService.getTodos().subscribe(response => {
      this.todos = response as Todo[];
    });
  }

  addTodo(todo: Todo) {
    this.todoService.addTodo(todo);
    this.todoService.getTodos();
  }

}
