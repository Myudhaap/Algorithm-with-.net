using TahapAkhirOCBC.Services;

namespace TahapAkhirOCBC.Views;

public class Question4View
{
    public static void Run()
    {
        bool isLoop = true;
        while (isLoop)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("|           MENU PALINDROME TERBESAR:          |");
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
        int input = 1;
        
        var res = Question4Service.MaxPolindrome(input);
        Console.WriteLine($"Input: {input}, Result: {res}");
        
        input = 2;
        res = Question4Service.MaxPolindrome(input);
        Console.WriteLine($"Input: {input}, Result: {res}");    
        
        input = 3;
        res = Question4Service.MaxPolindrome(input);
        Console.WriteLine($"Input: {input}, Result: {res}");
        
        input = 4;
        res = Question4Service.MaxPolindrome(input);
        Console.WriteLine($"Input: {input}, Result: {res}");
    }
}