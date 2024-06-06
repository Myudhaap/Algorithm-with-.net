namespace TahapAkhirOCBC.Views;

public class View
{
    public static void Run()
    {
        while (true)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("|                     MENU:                    |");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("| 1. Perfect Two                               |");
            Console.WriteLine("| 2. Hot Dog                                   |");
            Console.WriteLine("| 3. Programmer II                             |");
            Console.WriteLine("| 4. Palindrome Terbesar                       |");
            Console.WriteLine("| 5. Jual - Beli Saham                         |");
            Console.WriteLine("| 6. Angka Ajaib                               |");
            Console.WriteLine("| 7. Exit                                      |");
            Console.WriteLine("================================================");

            Console.Write("Enter Menu: ");
            var menu = Console.ReadLine();
            switch (menu)
            {
                case "1":
                    Question1View.Run();
                    break;
                case "2":
                    Question2View.Run();
                    break;
                case "3":
                    Question3View.Run();
                    break;
                case "4":
                    Question4View.Run();
                    break;
                case "5":
                    Question5View.Run();
                    break;
                case "6":
                    Question6View.Run();
                    break;
                case "7":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}