namespace Algorithm.Services;

public class Question5Service
{
    public static string Saham(List<int> numbers)
    {
        int min = numbers[0];
        int max = 0;
        int res = 0;

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] < numbers[i + 1] && min < numbers[i + 1])
            {
                max = numbers[i + 1];
            }
            else if(max > numbers[i + 1])
            {
                res = max - min;
                min = numbers[i + 1];
            }
            else if (numbers[i] > numbers[i + 1])
            {
                min = numbers[i + 1];
            }
        }

        if (res == 0) return "Harga selalu turun";
        return res.ToString();
    }
}