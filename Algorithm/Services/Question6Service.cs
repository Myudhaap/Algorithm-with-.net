namespace Algorithm.Services;

public class Question6Service
{
    public static string MagicNumber(int input)
    {
        var numberAsc = SortingAsc(input, true);
        var numberDesc = SortingAsc(input, false);

        int counter = 1;
        while (true)
        {
            int resTemp = numberDesc - numberAsc;
            Console.WriteLine($"({counter}) {numberDesc} - {numberAsc} = {resTemp}");
            if (resTemp == 6174)
            {
                break;
            }
            counter++;
            numberAsc = SortingAsc(resTemp, true);
            numberDesc = SortingAsc(resTemp, false);
        }
        
        return counter.ToString();
    }

    private static int SortingAsc(int number, bool Asc)
    {
        if (Asc)
        {
            return Convert.ToInt32(String.Join("", number.ToString().ToCharArray().OrderBy(n => n).ToList()));
        }
        else
        {
            return Convert.ToInt32(String.Join("", number.ToString().ToCharArray().OrderByDescending(n => n).ToList()));
        }
    }
}