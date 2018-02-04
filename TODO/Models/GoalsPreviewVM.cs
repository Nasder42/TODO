using System;
using System.Collections.Generic;

namespace TODO.Models
{
    public class GoalsPreviewVM
    {
        public GoalsPreviewVM()
        {
        }

        public List<Goal> Todos { get; set; }
        public string Intro { get; set; }
        public string Summary { get; set; }
    }
}
