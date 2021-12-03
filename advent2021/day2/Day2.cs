namespace advent2021.day2;

public static class Day2
{
    public static void DoWork()
    {
        string s;
        string[] strings;
        // Day 2
        Console.WriteLine();
        Console.WriteLine("Day 2");

        s = File.ReadAllText(@"day2/day2.txt");
        strings = s.Split(Environment.NewLine);

        int[,] position = new int[0, 0];
        int horizontal = 0;
        int depth = 0;

        Part1(strings, horizontal, depth);
        Console.WriteLine();
        Console.WriteLine();

        int aim = 0;
        depth = 0;
        horizontal = 0;
        Part2(strings, horizontal, depth, aim);
    }

    private static void Part2(string[] strings, int horizontal, int depth, int aim)
    {
        foreach (string line in strings)
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
    }

    private static void Part1(string[] strings, int horizontal, int depth)
    {
        foreach (string line in strings)
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
    }
}