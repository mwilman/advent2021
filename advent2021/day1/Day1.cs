namespace advent2021.day1;

public static class Day1
{
    public static void DoWork()
    {
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

        Part1(list, count);

        count = 0;

        Part2(list, count);
    }

    private static void Part2(List<int> list, int count)
    {
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
    }

    private static void Part1(List<int> list, int count)
    {
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
    }
}