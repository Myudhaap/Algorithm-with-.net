using TahapAkhirOCBC.Services;

namespace TahapAkhirOCBC.Views;

public class Question6View
{
    public static void Run()
    {
        bool isLoop = true;
        while (isLoop)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("|               MENU ANGKA AJAIB:              |");
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
        int input = 3124;
        
        var res = Question6Service.MagicNumber(input);
        Console.WriteLine($"Input: {input}, Result: {res}");
    }
}