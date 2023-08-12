using System;

class ConsoleUI {
    public void ShowMainMenu() {
        Console.WriteLine("========= Aplicativo de Lista de Tarefas =========");
        Console.WriteLine("1. Adicionar Tarefa");
        Console.WriteLine("2. Listar Tarefas");
        Console.WriteLine("3. Marcar Tarefa como Concluída");
        Console.WriteLine("4. Sair");
        Console.WriteLine("=================================================");
    }

    public int GetUserChoice() {
        Console.Write("Escolha uma opção: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int choice)) {
            return choice;
        } else {
            return -1; // Valor inválido
        }
    }

    public Task GetTaskDetailsFromUser() {
        Console.Write("Informe o título da tarefa: ");
        string title = Console.ReadLine();

        Console.Write("Informe a descrição da tarefa: ");
        string description = Console.ReadLine();

        return new Task { Title = title, Description = description };
    }

    public void ShowTaskList(List<Task> tasks) {
        Console.WriteLine("========= Lista de Tarefas =========");
        foreach (Task task in tasks) {
            Console.WriteLine($"ID: {task.Id}, Título: {task.Title}, Concluída: {(task.IsCompleted ? "Sim" : "Não")}");
        }
        Console.WriteLine("=====================================");
    }

    public void ShowSuccessMessage(string message) {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public void ShowErrorMessage(string message) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public int GetTaskToMarkAsCompleted() {
    Console.Write("Informe o ID da tarefa que deseja marcar como concluída: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int taskChoice)) {
        return taskChoice;
    } else {
        return -1; // Valor inválido
    }
}

}
