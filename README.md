# Max Length Word Finder

This C# console application allows users to input a sentence and finds the word with the maximum length. It demonstrates two methods for achieving this: a basic loop and a LINQ approach.

## Features

- Accepts a sentence input from the user.
- Identifies and outputs the longest word in the sentence.
- Implements both a traditional loop and LINQ for comparison.

## Usage

1. Clone the repository or download the source code.
2. Open the project in your preferred C# development environment (e.g., Visual Studio, Rider).
3. Run the application.
4. Enter a sentence when prompted.
5. The application will display the word with the maximum character length.

## Code Overview

```csharp
Console.WriteLine("Enter a sentence to find max length word");
var str = Console.ReadLine();
string[] strArray = str.Split(" ");
string outcomeString = string.Empty;

for (int i = 0; i < strArray.Length; i++)
    if (strArray[i].Length > outcomeString.Length)
        outcomeString = strArray[i];

Console.WriteLine($"Max character length word is {outcomeString}");

// Second Method Using Linq
Console.WriteLine($"('Linq') Max character length word is {strArray.MaxBy(x => x.Length)}");
```
