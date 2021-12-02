// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//Day1
Console.WriteLine();
Console.WriteLine("Day 1");

string text = File.ReadAllText(@"day1/day1.txt");
//Console.WriteLine(text);

string[] lines = text.Split(Environment.NewLine);


foreach (string line in lines)
{
    Console.WriteLine(line);    
}


int count = 0;
List<int> list = lines.Select(item => int.Parse(item)).ToList();

for (int i = 1; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
    if (list[i] > list[i - 1])
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

count = 0;

for (int i = 3; i < list.Count; i++)
{
    IEnumerable<int> previousSet = list.Skip(i - 3).Take(3);
    IEnumerable<int> currentSet = list.Skip(i - 2).Take(3);

    if (previousSet.Sum() < currentSet.Sum())
    {
        count++;
    }
}

Console.WriteLine($"Lösung 1 Teil2: {count}");

// Day 2
Console.WriteLine();
Console.WriteLine("Day 2");

text = File.ReadAllText(@"day2/day2.txt");
lines = text.Split(Environment.NewLine);
;

int[,] position = new int[0, 0];
int horizontal = 0;
int depth = 0;

foreach (string line in lines)
{
    string[] opAndNumber = line.Split(' ');
    string op = opAndNumber[0];
    int number = int.Parse(opAndNumber[1]);

    switch (op)
    {
        case "forward":
            Console.WriteLine("forward");
            horizontal += number;
            break;
        case "up":
            Console.WriteLine("up");
            depth -= number;
            break;
        case "down":
            Console.WriteLine("down");
            depth += number;
            break;
        default:
            throw new ArgumentOutOfRangeException();
    }
}

Console.WriteLine($"Endgültige Lösung Day2 Part 1: {horizontal * depth}");
Console.WriteLine();
Console.WriteLine();

int aim = 0;
depth = 0;
horizontal = 0;
foreach (string line in lines)
{
    string[] opAndNumber = line.Split(' ');
    string op = opAndNumber[0];
    int number = int.Parse(opAndNumber[1]);

    switch (op)
    {
        case "forward":
            Console.WriteLine("forward");
            horizontal += number;
            depth += aim * number;
            break;
        case "up":
            Console.WriteLine("up");
            aim -= number;
            break;
        case "down":
            Console.WriteLine("down");
            aim += number;
            break;
        default:
            throw new ArgumentOutOfRangeException();
    }
}

Console.WriteLine($"Endgültige Lösung Day2 Part 2: {horizontal * depth}");
