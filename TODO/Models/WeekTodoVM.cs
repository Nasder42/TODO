using System;
using System.Collections.Generic;
using System.Linq;
using TODO.Data;


namespace TODO.Models
{
    public class WeekTodoVM
    {
        
        public WeekTodoVM()
        {

            //Todos = TodoItemDatabase.GetWeekList();
        }

        public List<Goal> Todos { get; set; }
        public string Intro { get { return "Weekly Goals"; } }
        public string Summary { get { return " There is " + Todos.Count + " Goals this week"; } }
    }
}
