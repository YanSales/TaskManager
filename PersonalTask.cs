using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager
{
    public class PersonalTask : Task
    {
        public int ImportanceLevel{ get; set; }
        public PersonalTask(string title, string description, DateTime dueDate, int importanceLevel) : base(title, description, dueDate){
            ImportanceLevel = importanceLevel;
        }
        public void EditImportantLevel(int newImportanceLevel){
            ImportanceLevel = newImportanceLevel;
        }
    }
}