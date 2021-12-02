// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Day1
Console.WriteLine();
Console.WriteLine("Day 1");

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
List<int> list = lines.Select(item => int.Parse(item)).ToList();

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
Console.WriteLine($"Lösung 1: {count}");

// Day 2
Console.WriteLine();
Console.WriteLine("Day 2");

text = File.ReadAllText(@"day2/day2.txt");
lines = text.Split(Environment.NewLine); ;

int[,] position = new int[0,0];
int x = 0;
int y = 0;

foreach (string line in lines)
{
    string[] opAndNumber = line.Split(' ');
    string op = opAndNumber[0];
    int number = int.Parse(opAndNumber[1]);

    switch(op)
    {
        case "forward":
            Console.WriteLine("forward");
            x+=number;
            break;
        case "up":
            Console.WriteLine("up");
            y-=number;
            break;
        case "down":
            Console.WriteLine("down");
            y+=number;
            break;
        default:
            throw new ArgumentOutOfRangeException();
    }
}

Console.WriteLine($"Endgültige Lösung: {x * y}");