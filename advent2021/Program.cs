// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string text = File.ReadAllText(@"day1/day1.txt");
//Console.WriteLine(text);

string[] lines = text.Split(Environment.NewLine);

/*
foreach (string line in lines)
{
    Console.WriteLine(line);    
}
*/

int count = 0;
List<int> list = new List<int>();
foreach (string item in lines)
{
    list.Add(int.Parse(item));
}

for (int i = 1; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
    if (list[i] > list[i-1])
    {
        count++;
        Console.WriteLine("Increase");
    }
    else
    {
        Console.WriteLine("Decrease");
    }

    Console.WriteLine();
}
Console.WriteLine("Lösung 1: "+count);
