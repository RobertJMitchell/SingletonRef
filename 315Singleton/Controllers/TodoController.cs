using _315Singleton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _315Singleton.Controllers
{
    public class TodoController : Controller
    {

        private TodoService _service;

        public TodoController()
        {
            _service = TodoService.Instance;
        }

        // GET: Todo
        public ActionResult Index()
        {
            TodoIndexVm model = new TodoIndexVm();
            model.Greeting = "howdy from controller!";
            model.Tasks = _service.GetTodos();

            return View(model);
        }
        [HttpGet] // attribute for the GET
        public ActionResult Create()
        {
            TodoCreateVm model = new TodoCreateVm();
            model.Greeting = "Hello from Create Todo";
            return View(model);
        }
        [HttpPost] // attribute for POST/CREATE
        public ActionResult Create(TodoCreateVm cVm)
        {
            int myResults = _service.CreateTodo(cVm.Task);
            return RedirectToAction("Index");
        }

        // attribute for UPDATE METHOD
        public ActionResult Update(int Id) 
        {
            TodoUpdateVm updateVm = new TodoUpdateVm();
            Todo itemToUpdate = _service.FetchATodo(Id);
            updateVm.Id = itemToUpdate.Id;
            updateVm.Task = itemToUpdate.Task;
            updateVm.IsCompleted = itemToUpdate.IsCompleted;
            return View(updateVm);
        }
        [HttpPost]
        public ActionResult Update

    }
}