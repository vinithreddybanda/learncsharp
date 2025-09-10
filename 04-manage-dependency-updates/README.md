# Managing Dependency Updates in .NET Projects

Dependency management is a key part of maintaining healthy, secure, and up-to-date .NET applications. This guide covers how to understand, configure, and update package dependencies using best practices.

---

## 1. Understanding Semantic Versioning (SemVer)
Most .NET packages use [semantic versioning](https://semver.org/), which communicates the type of change in a new version:

- **Major version** (e.g., 1.0.0 → 2.0.0): Breaking changes. You may need to update your code.
- **Minor version** (e.g., 1.1.1 → 1.2.0): New features, but backward compatible.
- **Patch version** (e.g., 1.0.1 → 1.0.2): Bug fixes, safe to update.

| Type           | Example Change      | What it Means                |
|----------------|--------------------|------------------------------|
| Major          | 1.0.0 → 2.0.0      | Breaking changes             |
| Minor          | 1.1.1 → 1.2.0      | New features, safe to update |
| Patch          | 1.0.1 → 1.0.2      | Bug fixes, safe to update    |

**Tip:** Always read the release notes for major updates!

---

## 2. Configuring Version Ranges in .csproj
You can control which versions of a package your project will accept by editing the `Version` attribute in your `.csproj` file:

- `1.0` — Accepts any version >= 1.0
- `(1.0,)` — Accepts any version > 1.0
- `[1.0]` — Only version 1.0
- `(,1.0]` — Any version <= 1.0
- `[1.0,2.0]` — 1.0 to 2.0 inclusive
- `6.0.*` — Latest patch in 6.0.x
- `[1,3)` — 1.x or 2.x, but not 3.x

**Example:**
```xml
<PackageReference Include="Humanizer" Version="[2.7.9,3.0.0)" />
```
This means: Accept any Humanizer version from 2.7.9 up to, but not including, 3.0.0.

---

## 3. Finding and Updating Outdated Packages

- To list outdated packages:
  ```
  dotnet list package --outdated
  ```
- To update a package to the latest version:
  ```
  dotnet add package <PackageName>
  ```
- To update to a specific version or range:
  ```
  dotnet add package <PackageName> --version <version>
  ```

**Example:**
```
dotnet add package Humanizer --version 2.14.1
```

---

## 4. Security: Auditing Dependencies

- Use `dotnet list package --vulnerable` to check for known vulnerabilities in your dependencies (requires .NET 6+).
- Always keep dependencies up to date, especially for security patches.

---

## 5. Challenge: Practice Managing Dependency Updates

1. Add the `Humanizer` package to this project, but restrict it to a version range (e.g., `[2.7.9,3.0.0)`).
2. Use the CLI to check for outdated packages.
3. Update the package to the latest version within your allowed range.
4. Try using a floating version (e.g., `2.*`) and observe what version is installed.
5. Use the CLI to check for vulnerabilities (if supported by your .NET version).

---

## 6. Further Reading
- [NuGet Versioning Documentation](https://learn.microsoft.com/en-us/nuget/concepts/package-versioning)
- [dotnet CLI docs](https://learn.microsoft.com/en-us/dotnet/core/tools/)
- [NuGet.org](https://www.nuget.org/)

> **Tip:** For production projects, prefer specific version ranges for repeatable builds and fewer surprises.
