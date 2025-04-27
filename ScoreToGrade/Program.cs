using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int score = 0;
        Console.WriteLine("Введіть бали");
        string receivedscore = Console.ReadLine();
        score = int.Parse(receivedscore);
        if (score >= 90)
        {
            Console.WriteLine("Оцінка А");
        }
        else if (score >= 70 && score <= 89)
        {
            Console.WriteLine("Оцінка B");
        }
        else if (score >= 50 && score <= 69)
        {
            Console.WriteLine("Оцінка C");
        }
        else if (score >= 0 && score <= 49)
        {
            Console.WriteLine("Не здав");
        }
    }
}