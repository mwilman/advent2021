namespace advent2021.commons;

public static class Commons
{
    public static string[] readFile(string path)
    {
        string text = File.ReadAllText(path);
        //Console.WriteLine(text);

        string[] lines = text.Split(Environment.NewLine);

        return lines;
    }

    public static List<int> convertIntoInteger(string[] lines)
    {
        return lines.Select(item => int.Parse(item)).ToList();
    }

    public static List<int> readFileIntoInteger(string path)
    {
        string[] lines = readFile(path);
        List<int> result = convertIntoInteger(lines);

        return result;
    }
}