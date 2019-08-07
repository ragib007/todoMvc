using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoMVC.Models;

namespace TodoMVC.Controllers
{
    public class TodoController : Controller
    {
        public static Todos todos = new Todos();
        
        // GET: Todo
        public ActionResult Index()
        {
            return View(todos.todoList.OrderBy(x=>x.Id));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TodoModel todo)
        {
            todos.CreateTodo(todo);
            return RedirectToAction("Index");
        }

        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(TodoModel todo)
        {
            todos.UpdateTodo(todo);
            return RedirectToAction("Index");
        }

    }
}