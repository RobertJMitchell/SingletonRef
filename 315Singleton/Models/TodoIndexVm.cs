using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _315Singleton.Models
{
    public class TodoIndexVm
    {
        // Welcome message
        public string Greeting { get; set; }
        // List of objects/TODOS
        public List<Todo> Tasks { get; set; } 

    }
}