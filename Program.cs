// Step 02 - Variables, data types, input and constants

const int MaxDailyTasks = 10;
const string AppName = "Student Task Manager";

Console.WriteLine($"Application: {AppName}");
Console.WriteLine($"Maximum recommended daily tasks: {MaxDailyTasks}");
Console.WriteLine("====================");

Console.Write("Enter your name: ");
string name = Console.ReadLine() ?? "";

Console.Write("How many tasks do you want to complete today? ");
int taskGoal = int.Parse(Console.ReadLine() ?? "");

Console.Write("How many hours do you have available? ");
double availableHours = double.Parse(Console.ReadLine() ?? "");

Console.WriteLine();
Console.WriteLine($"Hello {name}!");
Console.WriteLine($"Your goal is {taskGoal} tasks.");
Console.WriteLine($"You have {availableHours} hours available.");

// Common C# data types
string studentName = "Alex";
int taskCount = 5;
double studyHours = 2.5;
decimal budget = 100.50m;
bool isCompleted = false;
char grade = 'A';

Console.WriteLine();
Console.WriteLine($"{studentName} has {taskCount} tasks, {studyHours} study hours, budget {budget}, completed: {isCompleted}, grade: {grade}");

// Type inference with var - the type is still fixed (string / int)
var courseName = ".NET Development";
var maxTasks = 10;
Console.WriteLine($"Course: {courseName}, max tasks: {maxTasks}");

// Safer numeric input
Console.WriteLine();
Console.Write("Enter a number: ");
bool valid = int.TryParse(Console.ReadLine(), out int number);

Console.WriteLine($"Valid number: {valid}");
Console.WriteLine($"Number: {number}");

// Your turn: student age, course name, knows C#, max tasks per day (constant)
const int MaxTasksPerDay = 8;

Console.WriteLine();
Console.Write("Enter your age: ");
int.TryParse(Console.ReadLine(), out int studentAge);

Console.Write("Enter your course name: ");
string studentCourse = Console.ReadLine() ?? "";

Console.Write("Do you already know C#? (y/n): ");
bool knowsCSharp = (Console.ReadLine() ?? "").Trim().ToLower() == "y";

Console.WriteLine();
Console.WriteLine($"Student age: {studentAge}");
Console.WriteLine($"Course name: {studentCourse}");
Console.WriteLine($"Already knows C#: {knowsCSharp}");
Console.WriteLine($"Maximum tasks allowed per day: {MaxTasksPerDay}");

// Investigate:
// 1. int.Parse("hello") throws a FormatException and the program crashes.
// 2. int.TryParse() returns false instead of throwing, and sets the out value to 0.
// 3. double is a binary floating-point type (fast, ~15-16 digits, small rounding errors);
//    decimal is a base-10 type (28-29 digits, exact for money values) but slower.

// Step 03 - Conditions: if, else and switch

Console.WriteLine();
Console.Write("How many tasks have you completed today? ");
int.TryParse(Console.ReadLine(), out int completedTasks);

if (completedTasks == 0)
{
    Console.WriteLine("Time to get started!");
}
else if (completedTasks < 3)
{
    Console.WriteLine("Good start. Keep going!");
}
else
{
    Console.WriteLine("Great progress!");
}

// Logical operators
int tasks = 4;
bool hasTime = true;

if (tasks >= 3 && hasTime)
{
    Console.WriteLine("You can probably finish your daily goal.");
}

// Your turn: extended menu with switch
Console.WriteLine();
Console.WriteLine("1. Add task");
Console.WriteLine("2. View tasks");
Console.WriteLine("3. Complete task");
Console.WriteLine("4. Remove task");
Console.WriteLine("0. Exit");

Console.Write("Choose an option: ");
int.TryParse(Console.ReadLine(), out int option);

switch (option)
{
    case 1:
        Console.WriteLine("Adding a task...");
        break;

    case 2:
        Console.WriteLine("Showing tasks...");
        break;

    case 3:
        Console.WriteLine("Completing a task...");
        break;

    case 4:
        Console.WriteLine("Removing a task...");
        break;

    case 0:
        Console.WriteLine("Goodbye!");
        break;

    default:
        Console.WriteLine("Invalid option.");
        break;
}
