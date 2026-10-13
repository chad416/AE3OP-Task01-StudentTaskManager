// Step 04 - Loops and lists
// (Steps 01-03 exercises are kept in the git history.)

Console.WriteLine("Student Task Manager");
Console.WriteLine("====================");

List<string> tasks = new List<string>();

tasks.Add("Review C# variables");
tasks.Add("Practice loops");
tasks.Add("Create a Console application");

Console.WriteLine($"Number of tasks: {tasks.Count}");

// foreach - process every item
foreach (string task in tasks)
{
    Console.WriteLine(task);
}

// for - access to the index
for (int i = 0; i < tasks.Count; i++)
{
    Console.WriteLine($"{i + 1}. {tasks[i]}");
}

bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("1. Add task");
    Console.WriteLine("2. View tasks");
    Console.WriteLine("3. Remove task");
    Console.WriteLine("0. Exit");

    Console.Write("Choose: ");
    if (!int.TryParse(Console.ReadLine(), out int option))
    {
        option = -1;
    }

    switch (option)
    {
        case 1:
            Console.Write("Enter task: ");
            string newTask = Console.ReadLine() ?? "";
            tasks.Add(newTask);
            Console.WriteLine("Task added.");
            break;

        case 2:
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
            break;

        case 3:
            // Your turn: remove a task by its number
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }

            Console.Write("Task to remove: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber)
                && taskNumber >= 1 && taskNumber <= tasks.Count)
            {
                // The list index starts at 0, the numbers shown to the user start at 1.
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Task removed.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
            break;

        case 0:
            running = false;
            break;

        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}

// Investigate:
// - Remove(item) deletes the first element equal to a given value.
// - RemoveAt(index) deletes the element at a position.
//   RemoveAt() is the right choice here, because the user selects a task by its number.
// - We subtract 1 because list indexes start at 0, but we show tasks to the user starting at 1.
