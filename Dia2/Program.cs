namespace Dia2;

class Program
{
    static void Main(string[] args)
    {
        //TODO
        //Mandatory
        string path = @"../../../Data/input.txt";
        string content = File.ReadAllText(path);

        
        string[] logs = content.Split('\n');
        bool canCount = false;
        int safeLogs = 0;
        LogChecker logChecker = new LogChecker();
        
        for (int i = 0; i < logs.Length; i++)
        {
            List<int> numberOnLine = new List<int>();
            string[] a = logs[i].Split(" ");
            foreach (string number in a)
            {
                numberOnLine.Add(int.Parse(number));
            }
            canCount = logChecker.isLogSafe(numberOnLine);
            
            if (canCount)
            {
                safeLogs++;
            }
        }

        Console.WriteLine(safeLogs);
        Console.ReadLine(); 
    }
}
