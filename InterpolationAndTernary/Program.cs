using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int age = 0;
        int number = 0;
        bool DataReceived = false;
        while (!DataReceived)
        {
            Console.WriteLine("Введіть ваш вік: ");
            string userage = Console.ReadLine();
            Console.WriteLine("Введіть ваше улюблене число: ");
            string FavNumber = Console.ReadLine();
            try
            {
                age = int.Parse(userage);
                number = int.Parse(FavNumber);
                if (number == 0)
                {
                    Console.WriteLine("Улюблене число не може бути нулем для ділення. Оберіть інше число.");
                }
                else
                {
                    DataReceived = true;
                }
            }
            catch
            {
                Console.WriteLine("Введіть коректне число");
            }
        }
        Console.WriteLine($"Сума віку та улюбленого числа: {age + number}");
        Console.WriteLine($"Різниця віку та улюбленого числа: {age - number}");
        Console.WriteLine($"Добуток віку та улюбленого числа: {age * number}");
        Console.WriteLine($"Ділення віку та улюбленого числа: {age / (double)number}");
        Console.WriteLine($"Чи однакові числа? {(age == number ? "так" : "ні")}");
        Console.WriteLine($"Чи різні значення? {(age != number ? "так" : "ні")}");
        Console.WriteLine($"Чи вік більший за улюблене число? {(age > number ? "так" : "ні")}");
        Console.WriteLine($"Чи улюблене число більший за вік? {(age < number ? "так" : "ні")}");
    }
}