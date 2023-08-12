using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        TaskManager taskManager = new TaskManager();
        ConsoleUI consoleUI = new ConsoleUI();

        while (true) {
            consoleUI.ShowMainMenu();
            int choice = consoleUI.GetUserChoice();

            switch (choice) {
                case 1:
                    Task newTask = consoleUI.GetTaskDetailsFromUser();
                    taskManager.AddTask(newTask);
                    consoleUI.ShowSuccessMessage("Tarefa adicionada com sucesso!");
                    break;
                case 2:
                    List<Task> tasks = taskManager.GetTasks();
                    consoleUI.ShowTaskList(tasks);
                    break;
                case 3:
                    List<Task> tasksToMark = taskManager.GetTasks();
                    consoleUI.ShowTaskList(tasksToMark);
                    int taskChoice = consoleUI.GetTaskToMarkAsCompleted();
                    
                    if (taskChoice >= 0 && taskChoice < tasksToMark.Count) {
                        taskManager.MarkTaskAsCompleted(tasksToMark[taskChoice].Id);
                        consoleUI.ShowSuccessMessage("Tarefa marcada como concluída!");
                    } else {
                        consoleUI.ShowErrorMessage("Opção inválida. Tarefa não marcada como concluída.");
                    }
                    break;
                case 4:
                    return; // Encerrar o aplicativo
                default:
                    consoleUI.ShowErrorMessage("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }
    }
}
