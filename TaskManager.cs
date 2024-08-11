using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager
{
    public class TaskManager
    {
        private List<Task> tasks;
        public TaskManager()
        {
            tasks = new List<Task>();
        }
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(string title)
        {
            Task taskToRemove = tasks.Find(t => t.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (taskToRemove != null)
            {
                tasks.Remove(taskToRemove);
            }
            else
            {
                Console.WriteLine("Tarefa não Encontrada");
            }
        }
        public void EditTask(string title, string newTitle, string newDescription, DateTime newDueDate)
        {
            Task taskToEdit = tasks.Find(t => t.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (taskToEdit != null)
            {
                taskToEdit.EditTask(newTitle, newDescription, newDueDate);
            }
            else
            {
                Console.WriteLine("Tarefa não Encontrada");
            }
        }

        public Task FindTaskByTitle(string title)
        {
            return tasks.FirstOrDefault(task => task.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
        public void ListTask()
        {
            foreach (Task task in tasks)
            {
                Console.WriteLine("Titulo: " + task.Title);
                Console.WriteLine("Descrição: " + task.Description);
                Console.WriteLine("Data de Vencimento: " + task.DueDate);
                Console.WriteLine("Concluída: " + task.IsCompleted);
                Console.ReadKey();
            }
        }
    }
}