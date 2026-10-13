// Step 05 - Methods and refactoring

List<string> tasks = new List<string>();

tasks.Add("Review C# variables");
tasks.Add("Practice loops");
tasks.Add("Create a Console application");

ShowTitle();
ShowMessage("Application started.");

int count = GetTaskCount(tasks);
Console.WriteLine($"You currently have {count} tasks.");

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
    Console.WriteLine("0. Exit");
}

int ReadOption()
{
    Console.Write("Choose: ");
    if (int.TryParse(Console.ReadLine(), out int option))
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
    Console.Write("Enter task: ");
    string task = (Console.ReadLine() ?? "").Trim();

    if (task.Length == 0)
    {
        ShowMessage("Task cannot be empty.");
        return;
    }

    tasks.Add(task);
    ShowMessage("Task added.");
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

// Investigate:
// 1. Variable scope is the part of the code where a variable exists and can be used.
//    A variable declared inside a method (or a { } block) only exists inside it.
// 2. No. A variable declared inside one method cannot be accessed directly from another
//    method - it has to be passed as a parameter or returned as a value.
//    That is why AddTask, ShowTasks and RemoveTask receive the list as a parameter.
