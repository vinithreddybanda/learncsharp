
# Using Packages in .NET Projects

## What are Packages and Dependencies?
- **Package**: A reusable library or tool you can add to your project (e.g., for dates, HTTP, etc.).
- **Dependency**: Any package or library your project needs to work.
- .NET uses NuGet (https://www.nuget.org/) as its main package registry.

## Why Use Packages?
- **Save time**: Use existing, tested code instead of writing everything yourself.
- **Better quality**: Many packages are maintained by experts and the community.
- **Focus**: Spend more time on your app, less on reinventing the wheel.

## How to Add a Package
1. Open a terminal in your project folder.
2. Run:
   ```
   dotnet add package <PackageName>
   ```
   Example:
   ```
   dotnet add package Humanizer
   ```
3. .NET downloads the package and updates your `.csproj` file.

## How to List Installed Packages
- To see top-level packages:
  ```
  dotnet list package
  ```
- To see all (including dependencies):
  ```
  dotnet list package --include-transitive
  ```

## How to Remove a Package
- Run:
  ```
  dotnet remove package <PackageName>
  ```

## How to Restore Packages
- Usually happens automatically on build/run.
- To force restore:
  ```
  dotnet restore
  ```

---

# Challenge 1: Use Humanizer to Manipulate Strings
1. Add the `Humanizer` package to this project using the CLI.
2. Use it in `Program.cs` to transform the string "csharp" into "Csharp" (capitalize the first letter) and print it.
3. Try listing and removing the package using the commands above.

---

# Challenge 2: Humanize Quantities and Dates
1. Add the `Humanizer` package if not already added.
2. In `Program.cs`, use Humanizer to:
   - Print pluralized forms for 0, 1, and 5 cases (e.g., "0 cases", "1 case", "5 cases").
   - Print humanized date/time values (e.g., "yesterday", "2 hours ago", "1 day", "2 weeks").
3. Use the following method templates in your code:
   ```csharp
   static void HumanizeQuantities()
   {
       // Use Humanizer's ToQuantity method
   }

   static void HumanizeDates()
   {
       // Use Humanizer's Humanize method
   }
   ```
4. Call these methods from `Main` and print the results as shown in the exercise.

---

> **Tip:** Always check a package's license, maintenance, and dependencies before using it in real projects.

## Resources
- [NuGet.org](https://www.nuget.org/)
- [dotnet CLI docs](https://learn.microsoft.com/en-us/dotnet/core/tools/)
