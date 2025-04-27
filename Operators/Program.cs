using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int x = 0;
        int y = 0;
        bool NumbersReceived = false;

        while (!NumbersReceived)
        {
            Console.WriteLine("Введіть переше число: ");
            string FirstNumber = Console.ReadLine();
            Console.WriteLine("Введіть друге число: ");
            string SecondNumber = Console.ReadLine();
            try
            {
                x = int.Parse(FirstNumber);
                y = int.Parse(SecondNumber);
                NumbersReceived = true;
            }
            catch
            {
                Console.WriteLine("Введіть коректне значення");
            }
        }

        //Інтерполяція
        Console.WriteLine($"Сума: = {x + y}");
        Console.WriteLine($"Різниця: = {x - y}");
        Console.WriteLine($"Добуток: = {x * y}");
        Console.WriteLine($"Ділення: = {x / (double)y}");
        //Інтерполяція та тернарний оператор
        Console.WriteLine($"Числа рівні? {(x == y ? "так" : "ні")}");
        Console.WriteLine($"Числа різні? {(x != y ? "так" : "ні")}");
        Console.WriteLine($"Перше число більше за друге? {(x > y ? "так" : "ні")}");
        Console.WriteLine($"Друге число більше за перше? {(x < y ? "так" : "ні")}");
    }
}