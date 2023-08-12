using System.Net.Http.Headers;
class TaskManager {

private List<Task> tasks = new List<Task>();

public void AddTask(Task task)
{
    ConsoleUI  consoleUI = new ConsoleUI();
    Task newTask = consoleUI.GetTaskDetailsFromUser();
    tasks.Add(newTask);

    Console.WriteLine("Tarefa adicionada com sucesso!");

}

 public List<Task> GetTasks()
 {
return tasks;
 }

   public void MarkTaskAsCompleted(int taskId) {
        Task task = tasks.Find(t => t.Id == taskId);
        if (task != null) {
            task.IsCompleted = true;
        }
    }
}