# Ninjanaut.Preconditions

Welcome to the project website! Preconditions is simple and lightweight C# library to ease arguments checks.

# Installation

from nuget package manager console
```powershell
PM> Install-Package Ninjanaut.Preconditions
```
from command line
```cmd
> dotnet add package Ninjanaut.Preconditions
```

| Version | Targets |
|- |- |
| 1.x | .NET 5 |

# Usage

```csharp
using Ninjanaut.Preconditions;

// any parameter
Check.NotNull(parameter);
Check.NotNull(parameter, nameof(parameter));
Check.NotNull(parameter, nameof(parameter), "Parameter cannot be null.");

// string parameter or IList<object> parameter
Check.NotNullOrEmpty(parameter);
Check.NotNullOrEmpty(parameter, nameof(parameter));
Check.NotNullOrEmpty(parameter, nameof(parameter), "Parameter cannot be null or empty.");

// any custom check
Check.Require(x > 0);
Check.Require(x > 0, "Parameter x has to be greater than zero!");
Check.Require(x > 0, "Parameter x has to be greater than zero!", nameof(x));

// It's also possible to assign the value directly from the checks.
var foo = Check.NotNull(parameter);
string bar = Check.NotNullOrEmpty(parameter);
List<object> foobars = Check.NotNullOrEmpty(parameter);
```

# Adding your custom checks

C# does not allow to create an extension method to static class or to create partial class across assemblies.
Therefore you can create your own static class as in the following example

```csharp
public static class MyCheck
{
    public static void NotZero(int number, string message = null, string paramName = null)
    {
        if (number == 0)
        {
            throw new ArgumentException(message, paramName);
        }
    }
}
```

and use it together with other checks

```csharp
MyCheck.NotZero(parameter);
Check.NotNull(parameter);
```

# Release notes

| Version | Note |
|- |- |
| 1.1.2 | XML documentation file added |
| 1.1.1 | Change NotNullOrEmpty method signature from List to IList |
| 1.1.0 | Add NotNullOrEmpty method for collection arguments |
| 1.0.0 | Initial release |

# Contribution

If you would like to contribute to the project, please send a pull request to the dev branch.
