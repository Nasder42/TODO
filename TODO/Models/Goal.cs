using System;
using SQLite;

namespace TODO.Models
{
    public class Goal
    {
        public Goal()
        {
            this.DateCreated = DateTime.Today;
            this.Completed = false;
            this.GoalType = GoalType.achieve;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public bool Completed { get; set; }
        public DateTime DatePlanned { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateCompleted { get; set; }
        public GoalType GoalType { get; set; }
    }

    public enum GoalType
    {
        achieve,
        obtain,
        win
    }
}
