using advent2021.commons;

namespace advent2021.day3;

public static class Day3
{
    public static void DoWork()
    {
        Console.WriteLine("Day 3");
        Part1();
        Part2();
    }

    private static void Part2()
    {
        string[] lines = Commons.readFile("day3/day3.txt");
        throw new NotImplementedException();
    }

    private static void Part1()
    {
        string[] lines = Commons.readFile("day3/day3.txt");
        int[,] array = new int[1000,12];

        string result = "";
        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            int lows = 0;
            int high = 0;

            for (int j = 0; j < line.Length; j++)
            {
                char c = line[j];
                int digit = int.Parse(c.ToString());
                array[i,j] = digit;
                
                Console.WriteLine(digit);
                switch (digit)
                {
                    case 0:
                        lows++;
                        break;
                    case 1:
                        high++;
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            
            if (lows > high)
            {
                result += "0";
            }

            if (high > lows)
            {
                result += "1";
            }
        }
    }
}