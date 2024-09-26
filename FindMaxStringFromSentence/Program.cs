Console.WriteLine("Enter a sentence to find max length word");
var str = Console.ReadLine();
string[] strArray = str.Split(" ");
string outcomeString = string.Empty;

for (int i = 0; i < strArray.Length; i++)
    if (strArray[i].Length > outcomeString.Length)
        outcomeString = strArray[i];

Console.WriteLine($"Max charcter length word is {outcomeString}");

// Second Method Using Linq

Console.WriteLine($"('Linq')Max charcter length word is {strArray.MaxBy(x => x.Length)}");