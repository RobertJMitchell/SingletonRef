using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _315Singleton.Models
{
    public class TodoUpdateVm
    {
        public int ID { get; set; }
        public string Task { get; set; }
        public bool IsCompleted { get; set; }
    }
}