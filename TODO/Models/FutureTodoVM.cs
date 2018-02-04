using System;
using System.Collections.Generic;

namespace TODO.Models
{
    public class FutureTodoVM
    {
        public FutureTodoVM()
        {
        }

        public List<Goal> Todos { get; set; }
        public string Intro { get { return "Future Goals"; } }
        public string Summary { get { return " There is " + Todos.Count + " future Goals"; } }
    }
}
