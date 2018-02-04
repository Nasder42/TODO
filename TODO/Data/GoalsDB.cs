using System;
using System.Collections.Generic;
using TODO.Models;
using System.Linq;

namespace TODO.Data
{
    public class GoalsDB
    {
        private static int _indexId = 1;
        private static List<Goal> _listTodos;
        private static readonly object mylockobject = new object();

        private GoalsDB()
        {

        }

        public static List<Goal> GetInstance()
        {
            lock (mylockobject)
            {
                if (_listTodos == null)
                {
                    _listTodos = new List<Goal>();
                    TestDataFiller();
                }
            }
            return _listTodos;
        }

        public static List<Goal> GetWeekList()
        {
            // Filter next 7 days.
            return _listTodos.FindAll(x => x.DatePlanned < DateTime.Now.AddDays(7)).FindAll(c => c.Completed == false);

        }

        public static List<Goal> GetMonthList()
        {
            // Filter next 30 days.
            return _listTodos.FindAll(x => x.DatePlanned < DateTime.Now.AddMonths(1)).FindAll(c => c.Completed == false);

        }

        public static List<Goal> GetQuarterList()
        {
            // Filter next 90 days.
            return _listTodos.FindAll(x => x.DatePlanned < DateTime.Now.AddMonths(3)).FindAll(c => c.Completed == false);
        }

        public static List<Goal> GetYearList()
        {
            // Filter next 90 days.
            return _listTodos.FindAll(x => x.DatePlanned < DateTime.Now.AddYears(1)).FindAll(c => c.Completed == false);
        }

        public static void AddTodo(Goal item)
        {
            item.Id = _indexId++;
            _listTodos.Add(item);
        }

        public static void RemoveGoal(string id)
        {
            var index = _listTodos.FindIndex(x => x.Id == int.Parse(id));
            _listTodos.RemoveAt(index);
        }

        public static void CompletedGoal(string id)
        {
            var index = _listTodos.FindIndex(x => x.Id == int.Parse(id));
            _listTodos[index].Completed = true;
        }


        public static List<Goal> GetCompleted()
        {
            return _listTodos.FindAll(x => x.Completed == true);
        }

        // Summary //
        // Gets only uncompleted future goals.
        public static List<Goal> GetFuture()
        {
            return _listTodos.FindAll(x => x.DatePlanned > DateTime.Now).FindAll(g => g.Completed == false);
        }

        private static void TestDataFiller()
        {
            _listTodos.Add(new Goal
            {
                Id = _indexId++,
                Title = "Start Training",
                Text = "I want to train regullary to feel more energic.",
                DatePlanned = DateTime.Now.AddDays(5)
            });

            _listTodos.Add(new Goal
            {
                Id = _indexId++,
                Title = "Stop Smoking",
                Text = "Stop smoking for the sake of Earth pollution.",
                DatePlanned = DateTime.Now.AddDays(15)
            });

            _listTodos.Add(new Goal
            {
                Id = _indexId++,
                Title = "Get 3 Girlfriends",
                Text = "Why not? I feel lonely!",
                DatePlanned = DateTime.Now.AddDays(20)
            });

            _listTodos.Add(new Goal
            {
                Id = _indexId++,
                Title = "Became google's VD",
                Text = "Looks good in the CV",
                DatePlanned = DateTime.Now.AddDays(-20),
                DateCompleted = DateTime.Now.AddDays(-10),
                Completed = true
            });

            _listTodos.Add(new Goal
            {
                Id = _indexId++,
                Title = "Buy Lambo",
                Text = "Garage feels too empty.",
                DatePlanned = DateTime.Now.AddMonths(5),
            });

            _listTodos.Add(new Goal
            {
                Id = _indexId++,
                Title = "Clean room",
                Text = "Mom's comming back from holidays.",
                DatePlanned = DateTime.Now.AddMonths(1),
            });
        }
    }
}
