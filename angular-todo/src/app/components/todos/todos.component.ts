import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { TodoService } from '../../todo.service';

@Component({
  selector: 'app-todos',
  templateUrl: './todos.component.html',
  styleUrls: ['./todos.component.css']
})

export class TodosComponent implements OnInit {
  constructor(private todoService: TodoService) { }

  todoList: string[] = [];

  ngOnInit() {
    this.todoService.getTodos().subscribe(response => {
      this.todoList = response as string[];
    });
  }

}
