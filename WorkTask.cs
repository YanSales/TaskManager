using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager
{
    public class WorkTask : Task
    {
        public string ProjectName{ get; set; }
        public WorkTask(string title, string description, DateTime dueDate, string projectName) : base(title, description, dueDate){
            ProjectName = projectName;
        }
        public void EditProjectName(string newProjectName){
            ProjectName = newProjectName;
        }
    }
}