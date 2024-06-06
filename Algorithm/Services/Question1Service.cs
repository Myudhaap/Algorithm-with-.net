using Algorithm.Utils;

namespace Algorithm.Services;

public class Question1Service
{
    public static string PerfectTwo(List<int> numbers, int input)
    {
        var res = new int[2];

        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = 0; j < numbers.Count ; j++)
            {
                if(i == j) continue;

                var tempVal = numbers[i] + numbers[j];
                if (tempVal == input)
                {
                    (res[0], res[1]) = (i, j);
                    return Util.ArrayToString(res);
                }
            }
        }

        return "<no way>";
    }
}