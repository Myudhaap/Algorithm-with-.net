using TahapAkhirOCBC.Services;
using TahapAkhirOCBC.Utils;

namespace TahapAkhirOCBC.Views;

public class Question3View
{
    public static void Run()
    {
        bool isLoop = true;
        while (isLoop)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("|              MENU PROGRAMMER II:             |");
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
        List<string> dictionary = new() { "pro", "gram", "merit", "program", "it", "programmer" };
        Console.WriteLine($"Sample Test : {Util.ListToString(dictionary)}");
        
        string input = "program";
        
        var res = Question3Service.Programmer(dictionary, input);
        Console.WriteLine($"Input: {input}, Result: {res}");
        
        input = "programit";
        res = Question3Service.Programmer(dictionary, input);
        Console.WriteLine($"Input: {input}, Result: {res}");    
        
        input = "programmerit";
        res = Question3Service.Programmer(dictionary, input);
        Console.WriteLine($"Input: {input}, Result: {res}");
        
        input = "programlala";
        res = Question3Service.Programmer(dictionary, input);
        Console.WriteLine($"Input: {input}, Result: {res}");
        
        input = "proletarian";
        res = Question3Service.Programmer(dictionary, input);
        Console.WriteLine($"Input: {input}, Result: {res}");
    }
}