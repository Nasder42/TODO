using System;
using System.Collections.Generic;
using System.Linq;

namespace TODO.Models
{
    public class QuarterTodoVM
    {
        public QuarterTodoVM()
        {
            
            //Todos = TodoItemDatabase.GetQuarterList();
        }

        public List<Goal> Todos { get; set; }
        public string Intro { get { return "Quarter Goals"; } }
        public string Summary { get { return " There is " + Todos.Count + " Goals this quarter"; } }
    }
}
