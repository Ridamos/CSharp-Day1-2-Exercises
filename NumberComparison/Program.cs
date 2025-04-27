using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int firstNumber = 0;
        int secondNumber = 0;
        int biggerNumber = 0;
        bool DataReceived = false;

        while (!DataReceived)
        {
            try
            {
                Console.WriteLine("Введіть перше число:");
                string first = Console.ReadLine();
                Console.WriteLine("Введіть друге число:");
                string second = Console.ReadLine();
                firstNumber = int.Parse(first);
                secondNumber = int.Parse(second);

                if (firstNumber == secondNumber)
                {
                    Console.WriteLine("Числа рівні");
                }
                else if (firstNumber > secondNumber)
                {
                    Console.WriteLine($"Перше число більше: {firstNumber}");
                }
                else
                {
                    Console.WriteLine($"Друге число більше: {secondNumber}");
                }
                DataReceived = true;
            }
            catch
            {
                Console.WriteLine("Введіть коректні данні");
            }
        }
    }
}