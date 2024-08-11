

namespace TaskManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            TaskManager manager = new TaskManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("=====Gerenciador de Tarefas=====");
                Console.WriteLine("1. Adicionar Tarefa");
                Console.WriteLine("2. Editar Tarefa");
                Console.WriteLine("3. Marcar Tarefa como Concluída");
                Console.WriteLine("4. Excluir Tarefa");
                Console.WriteLine("5. Listar Tarefas");
                Console.WriteLine("6. Sair");
                Console.WriteLine("Escolha uma Opção: ");

                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        AddNewTask(manager);
                        break;
                    case "2":
                        EditExistingTask(manager);
                        break;
                    case "3":
                        MarkTaskAsCompleted(manager);
                        break;
                    case "4":
                        RemoveTask(manager);
                        break;
                    case "5":
                        ListAllTasks(manager);
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }


            }





        }
        static void AddNewTask(TaskManager manager)
    {
        Console.WriteLine("Adicionar Nova Tarefa");
        Console.WriteLine("Escolha o tipo de tarefa: 1 - Pessoal, 2 - Trabalho");
        int taskType = int.Parse(Console.ReadLine());

        Console.Write("Título: ");
        string title = Console.ReadLine();
        Console.Write("Descrição: ");
        string description = Console.ReadLine();
        Console.Write("Data de Vencimento (dd/MM/yyyy): ");
        DateTime dueDate = DateTime.Parse(Console.ReadLine());

        if (taskType == 1)
        {
            Console.Write("Nível de Importância (1-5): ");
            int importanceLevel = int.Parse(Console.ReadLine());
            PersonalTask personalTask = new PersonalTask(title, description, dueDate, importanceLevel);
            manager.AddTask(personalTask);
        }
        else if (taskType == 2)
        {
            Console.Write("Nome do Projeto: ");
            string projectName = Console.ReadLine();
            WorkTask workTask = new WorkTask(title, description, dueDate, projectName);
            manager.AddTask(workTask);
        }

        Console.WriteLine("Tarefa adicionada com sucesso!");
    }

    static void EditExistingTask(TaskManager manager)
    {
        Console.WriteLine("Editar Tarefa");
        Console.WriteLine("Digite o título da tarefa que deseja editar:");
        string title = Console.ReadLine();

        Console.Write("Novo Título: ");
        string newTitle = Console.ReadLine();
        Console.Write("Nova Descrição: ");
        string newDescription = Console.ReadLine();
        Console.Write("Nova Data de Vencimento (dd/MM/yyyy): ");
        DateTime newDueDate = DateTime.Parse(Console.ReadLine());

        manager.EditTask(title, newTitle, newDescription, newDueDate);

        Console.WriteLine("Tarefa editada com sucesso!");
    }

    static void MarkTaskAsCompleted(TaskManager manager)
    {
        Console.WriteLine("Marcar Tarefa como Concluída");
        Console.WriteLine("Digite o título da tarefa que deseja marcar como concluída:");
        string title = Console.ReadLine();

        Task taskToComplete = manager.FindTaskByTitle(title);
        if (taskToComplete != null)
        {
            taskToComplete.MarkAsCompleted();
            Console.WriteLine("Tarefa marcada como concluída!");
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada.");
        }
    }

    static void RemoveTask(TaskManager manager)
    {
        Console.WriteLine("Excluir Tarefa");
        Console.WriteLine("Digite o título da tarefa que deseja remover:");
        string title = Console.ReadLine();

        manager.RemoveTask(title);

        Console.WriteLine("Tarefa removida com sucesso!");
    }

    static void ListAllTasks(TaskManager manager)
    {
        Console.WriteLine("Listar Tarefas");
        manager.ListTask();
    }
    }
}



