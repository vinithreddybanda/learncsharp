# Debugging .NET Programs in Visual Studio Code

Debugging is a critical skill for every developer. This guide covers how to use the Visual Studio Code debugger with .NET, set breakpoints, inspect variables, use the call stack, and add logging and assertions to your code.

---

## 1. What is a Debugger?
A debugger is a tool that lets you:
- Pause your program at any line (breakpoints)
- Step through code line by line
- Inspect variables and program state at any point
- Rewind the call stack to find the source of errors

**Why use a debugger?**
- Avoid guessing what's wrong—see exactly how your code runs
- Find and fix bugs faster
- Understand unfamiliar code

---

## 2. Setting Up Debugging in Visual Studio Code
- Open a C# file in VS Code. If prompted, install the C# extension.
- When prompted, add required assets for build and debug (select Yes).
- These assets include a `.vscode/launch.json` file for debug configuration.

---

## 3. Using Breakpoints
- Click to the left of a line number to set a breakpoint (red dot).
- Right-click for conditional breakpoints (only break when a condition is true).
- Use the Breakpoints panel to view, enable/disable, or remove breakpoints.

---

## 4. Debugger Controls and Panels
- **Start/Continue**: Run or resume your program
- **Step Over**: Run the next line (don’t enter functions)
- **Step Into**: Enter a function call
- **Step Out**: Finish the current function and return
- **Restart/Stop**: Restart or end debugging

**Panels:**
- **Variables**: See current values of all variables in scope
- **Watch**: Track specific variables or expressions
- **Call Stack**: See the trail of function calls leading to the current line
- **Debug Console**: Evaluate expressions, view logs, and interact with your program

---

## 5. Debugging Example: The Fibonacci Bug

### The Problem
Given this code:
```csharp
int result = Fibonacci(5);
Console.WriteLine(result);

static int Fibonacci(int n)
{
    int n1 = 0;
    int n2 = 1;
    int sum;

    for (int i = 2; i < n; i++)
    {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
    }

    return n == 0 ? n1 : n2;
}
```
Expected output for `Fibonacci(5)` is 5, but the program prints 3. Why?

### Debugging Steps
1. Set a breakpoint at the start of the program.
2. Step into the `Fibonacci` function.
3. Use the Variables panel to inspect `n`, `n1`, `n2`, `sum`, and `i`.
4. Step through the loop and observe how values change.
5. Notice the loop condition: `i < n`—it should be `i <= n` to include the nth value.
6. Fix the loop:
   ```csharp
   for (int i = 2; i <= n; i++)
   ```
7. Run again—now the output is correct!

---

## 6. Logging and Tracing in .NET

### Why Log?
- Debuggers are great for real-time analysis, but logs help with issues that happen over time or in production.
- Use logging to record important events, errors, and variable values.

### Logging APIs
- `System.Console.WriteLine`: Always writes to the console (visible to users in console apps)
- `System.Diagnostics.Trace.WriteLine`: Writes to listeners (enabled with TRACE constant)
- `System.Diagnostics.Debug.WriteLine`: Writes to the debug output (enabled with DEBUG constant)

**Example:**
```csharp
Console.WriteLine("User-facing message");
Trace.WriteLine("Trace message");
Debug.WriteLine("Debug message");
```

### Conditional Logging
- `Debug.WriteLineIf(condition, message)` and `Trace.WriteLineIf(condition, message)` log only if the condition is true.

### Assertions
- `Debug.Assert(condition, message)` stops execution in debug mode if the condition is false.
- Use assertions to catch invalid states early during development.

**Example:**
```csharp
Debug.Assert(divisor != 0, "Divisor should not be zero!");
```

---

## 7. Challenge: Debug and Instrument the Fibonacci Program

1. Create a new .NET console project for debugging.
2. Add the Fibonacci code above to `Program.cs`.
3. Use the debugger to find and fix the bug.
4. Add logging with `Debug.WriteLine` at the start of the Fibonacci method and inside the loop.
5. Use `Debug.WriteLineIf` to log when `sum == 1`.
6. Add a `Debug.Assert` before returning to check the result.
7. Try running in Debug and Release modes to see the difference.

---

## 8. Further Reading
- [VS Code Debugging Documentation](https://code.visualstudio.com/docs/editor/debugging)
- [System.Diagnostics Namespace](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics)
- [Debugging in .NET](https://learn.microsoft.com/en-us/dotnet/core/diagnostics/)

> **Tip:** Mastering the debugger will save you hours of frustration and make you a much more effective developer!
