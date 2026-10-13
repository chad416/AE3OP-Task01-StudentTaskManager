// Step 06 - Enums, constants and final integration

const int MaxTasks = 10;

List<string> tasks = new List<string>();

tasks.Add("Review C# variables");
tasks.Add("Practice loops");
tasks.Add("Create a Console application");

// Enum example
TaskPriority priority = TaskPriority.High;
Console.WriteLine(priority);
ShowPriorityAdvice(priority);

ShowTitle();
ShowMessage("Application started.");

bool running = true;

while (running)
{
    ShowMenu();
    int option = ReadOption();

    switch (option)
    {
        case 1:
            AddTask(tasks);
            break;

        case 2:
            ShowTasks(tasks);
            break;

        case 3:
            RemoveTask(tasks);
            break;

        case 4:
            ShowTaskCount(tasks);
            break;

        case 0:
            running = false;
            ShowMessage("Goodbye!");
            break;

        default:
            ShowMessage("Invalid option.");
            break;
    }
}

void ShowTitle()
{
    Console.WriteLine();
    Console.WriteLine("Student Task Manager");
    Console.WriteLine("====================");
}

void ShowMessage(string message)
{
    Console.WriteLine($"[INFO] {message}");
}

int GetTaskCount(List<string> tasks)
{
    return tasks.Count;
}

void ShowMenu()
{
    Console.WriteLine();
    Console.WriteLine("1. Add task");
    Console.WriteLine("2. View tasks");
    Console.WriteLine("3. Remove task");
    Console.WriteLine("4. Show task count");
    Console.WriteLine("0. Exit");
}

int ReadOption()
{
    Console.Write("Choose: ");
    string? input = Console.ReadLine();

    // End of input (e.g. Ctrl+Z) closes the application.
    if (input == null)
    {
        return 0;
    }

    if (int.TryParse(input, out int option))
    {
        return option;
    }

    return -1;
}

void ShowTasks(List<string> tasks)
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("No tasks available.");
        return;
    }

    for (int i = 0; i < tasks.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {tasks[i]}");
    }
}

void AddTask(List<string> tasks)
{
    if (tasks.Count >= MaxTasks)
    {
        Console.WriteLine("Maximum number of tasks reached.");
        return;
    }

    Console.Write("Enter task: ");
    string task = (Console.ReadLine() ?? "").Trim();

    if (task.Length == 0)
    {
        ShowMessage("Task cannot be empty.");
        return;
    }

    TaskPriority taskPriority = ReadPriority();

    tasks.Add($"{task} [{taskPriority}]");
    ShowMessage("Task added.");
    ShowPriorityAdvice(taskPriority);
}

TaskPriority ReadPriority()
{
    Console.Write("Priority (1 = Low, 2 = Medium, 3 = High): ");
    string input = Console.ReadLine() ?? "";

    switch (input.Trim())
    {
        case "1":
            return TaskPriority.Low;

        case "3":
            return TaskPriority.High;

        default:
            return TaskPriority.Medium;
    }
}

void ShowPriorityAdvice(TaskPriority priority)
{
    switch (priority)
    {
        case TaskPriority.Low:
            Console.WriteLine("This task can wait.");
            break;

        case TaskPriority.Medium:
            Console.WriteLine("Try to finish this task today.");
            break;

        case TaskPriority.High:
            Console.WriteLine("Prioritize this task.");
            break;
    }
}

void RemoveTask(List<string> tasks)
{
    ShowTasks(tasks);

    if (tasks.Count == 0)
    {
        return;
    }

    Console.Write("Task to remove: ");
    if (int.TryParse(Console.ReadLine(), out int taskNumber)
        && taskNumber >= 1 && taskNumber <= tasks.Count)
    {
        // The list index starts at 0, the numbers shown to the user start at 1.
        tasks.RemoveAt(taskNumber - 1);
        ShowMessage("Task removed.");
    }
    else
    {
        ShowMessage("Invalid task number.");
    }
}

void ShowTaskCount(List<string> tasks)
{
    int count = GetTaskCount(tasks);

    Console.WriteLine($"You currently have {count} tasks.");
    Console.WriteLine($"Maximum allowed: {MaxTasks}");
    Console.WriteLine($"Remaining capacity: {MaxTasks - count}");
}

enum TaskPriority
{
    Low,
    Medium,
    High
}
