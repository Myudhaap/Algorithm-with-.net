using TahapAkhirOCBC.Services;
using TahapAkhirOCBC.Utils;

namespace TahapAkhirOCBC.Views;

public class Question1View
{
    public static void Run()
    {
        bool isLoop = true;
        while (isLoop)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("|               MENU PERFECT TWO:              |");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("| 1. Sample Input                              |");
            Console.WriteLine("| 2. Exit                                      |");
            Console.WriteLine("================================================");

            Console.Write("Enter Menu: ");
            var menu = Console.ReadLine();
            switch (menu)
            {
                case "1":
                    Menu1();
                    break;
                case "2":
                    isLoop = false;
                    break;
            }
        }
    }

    public static void Menu1()
    {
        List<int> numbers = new() { 2, 7, 11, 15 };

        Console.WriteLine($"Sample Test : {Util.ListToString(numbers)}");
        var input = 9;
        var res = Question1Service.PerfectTwo(numbers, input);
        Console.WriteLine($"Input: {input}, Result: {res}");
        
        input = 22;
        res = Question1Service.PerfectTwo(numbers, input);
        Console.WriteLine($"Input: {input}, Result: {res}");    
        
        input = 13;
        res = Question1Service.PerfectTwo(numbers, input);
        Console.WriteLine($"Input: {input}, Result: {res}");
        
        input = 11;
        res = Question1Service.PerfectTwo(numbers, input);
        Console.WriteLine($"Input: {input}, Result: {res}");
        
        input = 19;
        res = Question1Service.PerfectTwo(numbers, input);
        Console.WriteLine($"Input: {input}, Result: {res}");
    }
}