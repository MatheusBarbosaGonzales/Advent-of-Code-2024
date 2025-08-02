namespace Dia2;

public class LogChecker
{

    public bool isLogSafe(List<int> numberOnLine)
    {
        bool subindo = false;
        bool descendo = false;
        for (int j = 1; j < numberOnLine.Count; j++)
        {
            int previusNumber = numberOnLine[j - 1];
            int currentNumber = numberOnLine[j];
            
            if (previusNumber == currentNumber)
            {
                return false;
            }

            if (previusNumber < currentNumber)
            {
                subindo = true;
            }

            if (previusNumber > currentNumber)
            {
                descendo = true;
            }

            if (subindo && descendo)
            {
                return false;
            }
            
            if (descendo  && previusNumber-3 > currentNumber)
            {
                return false;
            }
            
            if (subindo  && currentNumber > previusNumber+3)
            {
                return false;
            }
        }
        return true;
        
    }
}
