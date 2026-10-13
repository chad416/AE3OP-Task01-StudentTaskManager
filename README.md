# Student Task Manager

AE3OP – Task 01. Introduction to C# / .NET

Console application built by following Steps 1–6 of the
[.NET + C# Console Tutorial](https://github.com/icebeam7/oop-tutorials/blob/main/00-introduction/README.md).

## Run

```bash
dotnet run
```

Requires the .NET 10 SDK.

## Steps

Each step is a separate commit, so the progress of the program can be followed in the history.

| Step | Topic | Commit |
|---|---|---|
| 1 | Create and run a .NET Console app | [f3d9670](../../commit/f3d9670) |
| 2 | Variables, input, output, constants | [6b62e56](../../commit/6b62e56) |
| 3 | Conditions and switch | [441f994](../../commit/441f994) |
| 4 | Loops and lists | [7145c29](../../commit/7145c29) |
| 5 | Methods and refactoring | [9d04bc4](../../commit/9d04bc4) |
| 6 | Enums and final integration | latest `main` |

## Final application

```text
Student Task Manager
====================

1. Add task
2. View tasks
3. Remove task
4. Show task count
0. Exit
```

- Tasks are stored in a `List<string>` with a priority (`TaskPriority` enum: Low / Medium / High).
- The number of tasks is limited by the constant `MaxTasks = 10`.
- Input is validated with `int.TryParse()`, so invalid input does not crash the program.

## Investigate – answers

**Step 1 – `Console.Write()` vs `Console.WriteLine()`**
`Write()` prints text and keeps the cursor on the same line; `WriteLine()` prints text and then moves to a new line.

**Step 2**
1. `int.Parse("hello")` throws a `FormatException` and the program crashes.
2. `int.TryParse()` returns `false` instead of throwing an exception and sets the `out` value to `0`.
3. `double` is a binary floating-point type (about 15–16 digits, small rounding errors, fast).
   `decimal` is a base-10 type (28–29 digits, exact for values like money, slower).

**Step 4**
- `Remove(item)` removes the first element equal to the given value; `RemoveAt(index)` removes the element at a position.
  `RemoveAt()` is more appropriate, because the user selects a task by its number.
- We subtract `1` because list indexes start at `0`, but tasks are shown to the user starting at `1`.

**Step 5**
1. Variable scope is the part of the code where a variable exists and can be used. A variable declared
   inside a method or a `{ }` block exists only inside it.
2. No. A variable declared inside one method cannot be accessed directly from another method;
   it has to be passed as a parameter or returned as a value.
