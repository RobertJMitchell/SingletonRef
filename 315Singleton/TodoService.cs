using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _315Singleton.Models;

namespace _315Singleton
{
    public class TodoService
    {

        // private instance of TODO SERVICE
        private static TodoService _instance = null;

        // Private list of todos
        private List<Todo> _todos { get; set; }

        // Seed id / auto increment
        private int _seedId;



        // Singleton...
        public static TodoService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TodoService();
                }
                return _instance;
            }
        }


        // Constructor Method
        private TodoService()
        {
            _seedId = 1;
            _todos = new List<Todo>();
            Todo tempTodo = new Todo() { Id = _seedId, IsCompleted = false, Task = "add something!" };
            _seedId++;
            _todos.Add(tempTodo);
        }

        // READ/GET - all todos in list
        public List<Todo> GetTodos()
        {
            return _todos;
        }

        // READ/GET - a single todo item
        public Todo GetTodoItem(int id)
        {
            return _todos.FirstOrDefault(t => t.Id == id);
        }

        // CREATE/POST - create a new todo
        public int CreateTodo(string task)
        {
            Todo nTodo = new Todo()
            {
                Id = _seedId,
                Task = task,
                IsCompleted = false
            };
            _todos.Add(nTodo);
            _seedId++;
            return nTodo.Id;
        }
        //Fetch a Todo
        public Todo FetchATodo(int Id){
            Todo uTodo = _todos.FirstOrDefault(t => t.Id == Id)
            return uTodo;
        }
        // UPDATE/PUT - a specific todo item
        public void UpdateTodo(int id, string task, bool isCompleted)
        {
            Todo uTodo = _todos.FirstOrDefault(t => t.Id == id);
            if (uTodo == null)
            {
                return;
            };
            uTodo.Task = task;
            uTodo.IsCompleted = isCompleted;
            ///
        }


        internal int FetchATodo()
        {
            throw new NotImplementedException();
        }
    }
}