using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int number = 0;
        Console.WriteLine("Введіть число");
        string enterednumber = Console.ReadLine();
        number = int.Parse(enterednumber);
        if (number % 2 == 0)
        {
            Console.WriteLine("Число парне");
        }
        else
        {
            Console.WriteLine("Число не парне");
        }
    }
}