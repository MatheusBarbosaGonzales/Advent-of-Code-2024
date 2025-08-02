namespace Dia1;

class Program
{
    static void Main(string[] args)
    {
        List<int> rightSide = new List<int>();
        List<int> leftSide = new List<int>();
        List<int> result = new List<int>();
        int answer = 0;
        string path = @"../../../Data/input.txt";
        Console.WriteLine(path);
        string content = File.ReadAllText(path);
        content = content.Trim();
        content = content.Replace("\n", "   ");
        var divided = content.Split("   ");

        for (int i = 0; i < divided.Length; i++)
        {
            if ((i + 1) % 2 == 0)
            {
                rightSide.Add(int.Parse(divided[i]));
                continue;
            }

            leftSide.Add(int.Parse(divided[i]));
        }
        for (int i = 0; i < leftSide.Count; i++)
        {
            List<int> counter = rightSide.FindAll(x => x == leftSide[i]);
            result.Add(leftSide[i] * counter.Count);
        }
        foreach (var item in result)
        {
            answer += item;
        }
        Console.WriteLine(answer);
        Console.ReadLine();
    }
}