using TahapAkhirOCBC.Services;
using TahapAkhirOCBC.Utils;

namespace TahapAkhirOCBC.Views;

public class Question5View
{
    public static void Run()
    {
        bool isLoop = true;
        while (isLoop)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("|             MENU JUAL-BELI SAHAM:            |");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("| 1. Sample Test                               |");
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
        List<int> input = new() { 5, 6, 15, 3, 10, 22, 15 };
        
        var res = Question5Service.Saham(input);
        Console.WriteLine($"Input: {Util.ListToString(input)}, Result: {res}");
        
        input = new() { 10, 15, 8, 7, 14};
        res = Question5Service.Saham(input);
        Console.WriteLine($"Input: {Util.ListToString(input)}, Result: {res}");    
        
        input = new() {100, 90, 80, 75, 65};
        res = Question5Service.Saham(input);
        Console.WriteLine($"Input: {Util.ListToString(input)}, Result: {res}");
    }
}