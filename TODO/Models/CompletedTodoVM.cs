using System;
using System.Collections.Generic;

namespace TODO.Models
{
    public class CompletedTodoVM
    {
        public CompletedTodoVM()
        {
        }

        public List<Goal> Todos { get; set; }
        public string Intro { get { return "Completed Goals"; } }
        public string Summary { get { return " There is " + Todos.Count + " Goals completed"; } }
    }

}