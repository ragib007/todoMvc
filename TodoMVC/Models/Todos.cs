using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static TodoMVC.Models.TodoModel;

namespace TodoMVC.Models
{
    public class Todos
    {
        public List<TodoModel> todoList = new List<TodoModel>();
        
        public Todos()
        {

            todoList.Add(new TodoModel { Id = 1, Name = "Wake up", TodoStatus=Status.Done });
            todoList.Add(new TodoModel { Id = 2, Name = "Go to market", TodoStatus = Status.Open });
            todoList.Add(new TodoModel { Id = 3, Name = "Attend meeting", TodoStatus = Status.Open });
            
        }

        public void CreateTodo(TodoModel todoModel)
        {
            todoModel.Id = todoList.Count() + 1;
            todoList.Add(todoModel);
        }

        public void UpdateTodo(TodoModel todoModel)
        {
            foreach(var todo in todoList)
            {
                if(todo.Id==todoModel.Id)
                {
                    todoList.Remove(todo);
                    todoList.Add(todoModel);
                    break;
                }
            }
        }

    

    }
}