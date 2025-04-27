using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int age = 19;
        string name = "Вова";
        bool isStudent = true;
        double height = 1.75;
        char initial = name[0];

        Console.WriteLine("Привіт, мене звати " + name);
        Console.WriteLine("Мені " + age + " років");
        Console.WriteLine("Я студент: " + isStudent);
        Console.WriteLine("Мій зріст: " + height + "м");
        Console.WriteLine("Мій ініціал: " + initial);

        Console.WriteLine("\nЯк тебе звати?");
        string username = Console.ReadLine();
        char userInitial = username[0];

        int amountOfMoney = 0;
        bool isMoney = false;
        while (!isMoney)
        {
            Console.WriteLine("Позич трохи грошей ₴");
            string receivedMoney = Console.ReadLine();
            try
            {
                amountOfMoney = int.Parse(receivedMoney);
                isMoney = true;
            }
            catch
            {
                Console.WriteLine("Please enter correct value");
            }
        }

        int userage = 0;
        bool ValidUserAge = false;
        while (!ValidUserAge)
        {
            Console.WriteLine("Скільки тобі років?");
            string enteredage = Console.ReadLine();
            try
            {
                userage = int.Parse(enteredage);
                ValidUserAge = true;
            }
            catch
            {
                Console.WriteLine("Будь ласка, введіть корректне число");
            }
        }


        double userheight = 0;
        bool ValidUserHeight = false;
        while (!ValidUserHeight)
        {
            Console.WriteLine("Який в тебе зріст? Наприклад 1,75 м");
            string enteredheight = Console.ReadLine();
            try
            {
                userheight = double.Parse(enteredheight);
                ValidUserHeight = true;
            }
            catch
            {
                Console.WriteLine("Введіть коректне число, приклад 1,75 м");
            }
        }

        Console.WriteLine("Привіт, " + username);
        Console.WriteLine("Тобі " + userage + " років");
        Console.WriteLine("Твій зріст це: " + userheight + " м");
        Console.WriteLine("Твій ініціал це " + userInitial);
        Console.WriteLine("Ти позичив: " + amountOfMoney + " грн");
    }
}

