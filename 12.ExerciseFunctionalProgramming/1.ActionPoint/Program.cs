List <string> list = Console.ReadLine().Split(" ").ToList();

Action<string> print = name =>  Console.WriteLine(name);
list.ForEach(print);