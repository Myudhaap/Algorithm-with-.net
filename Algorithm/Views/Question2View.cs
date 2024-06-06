using Algorithm.Services;
using Algorithm.Utils;

namespace Algorithm.Views;

public class Question2View
{
    public static void Run()
    {
        bool isLoop = true;
        while (isLoop)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("|                 MENU HOT DOG:                |");
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
                default:
                    Console.WriteLine("Invalid menu, please enter valid menu.");
                    break;
            }
        }
    }

    public static void Menu1()
    {
        List<string> dictionary = new() { "hot", "dot", "dog", "lot", "log" };
        Console.WriteLine($"Sample Test : {Util.ListToString(dictionary)}");
        
        string[] input = { "hot", "dog" };
        
        var res = Question2Service.HotDog(dictionary, input);
        Console.WriteLine($"Input: {Util.ArrayToString(input)}, Result: {res}");
        
        (input[0], input[1]) = ("hit", "dog");
        res = Question2Service.HotDog(dictionary, input);
        Console.WriteLine($"Input: {Util.ArrayToString(input)}, Result: {res}");    
        
        (input[0], input[1]) = ("hit", "dig");
        res = Question2Service.HotDog(dictionary, input);
        Console.WriteLine($"Input: {Util.ArrayToString(input)}, Result: {res}");
        
        (input[0], input[1]) = ("dot", "red");
        res = Question2Service.HotDog(dictionary, input);
        Console.WriteLine($"Input: {Util.ArrayToString(input)}, Result: {res}");
    }
}