namespace Algorithm.Services;

public class Question4Service
{
    public static int MaxPolindrome(int n)
    {
        int res = 0;

        var upperLimit = (int)Math.Pow(10, n) - 1;
        var lowerLimit = (int)Math.Pow(10, n - 1);

        for (int i = lowerLimit; i <= upperLimit; i++)
        {
            for (int j = i; j <= upperLimit; j++)
            {
                var tempMultiple = i * j;
                if (IsPolindrome(tempMultiple) && tempMultiple > res)
                {
                    res = tempMultiple;
                }
            }
        }
        
        return res;
    }

    private static bool IsPolindrome(int n)
    {
        var s = n.ToString();
        var sRev = String.Join("", s.Reverse());

        if (s.Equals(sRev))
        {
            return true;
        }

        return false;
    }
}