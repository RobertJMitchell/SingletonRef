using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _315Singleton.Models
{
    public class Todo
    {
        // GUID
        public int Id { get; set; }
        // Thing needs to be done
        public string Task { get; set; }
        // Is the task completed
        public bool IsCompleted { get; set; }
    }
}