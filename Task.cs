using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace TaskManager
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; private set; }

        public Task(string title, string description, DateTime dueDate)
        {

            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = false;
        }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }

        public void EditTask(string newTitle, string newDescription, DateTime newDueDate){
            Title = newTitle;
            Description = newDescription;
            DueDate = newDueDate;
        }

    }
}