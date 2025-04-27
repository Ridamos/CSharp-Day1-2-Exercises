# Мої перші вправи на C# (День 1-2)

Цей репозиторій містить колекцію невеликих консольних програм, створених під час вивчення основ мови програмування C#. Кожен проект знаходиться в окремій папці та демонструє певні концепції.

## Проекти

Ось короткий опис кожного проекту:

*   **InterpolationAndTernary:**
    *   Призначення: Демонструє використання інтерполяції рядків (`$"{змінна}"`) для зручного форматування виводу та тернарного оператора (`умова ? значення1 : значення2`) для скороченого запису умов.
    *   Ключові концепції: Вивід на консоль, інтерполяція рядків, тернарний оператор.

*   **NumberComparison:**
    *   Призначення: Програма запитує у користувача два числа і порівнює їх, виводячи, яке число більше, або повідомляючи, що вони рівні.
    *   Ключові концепції: Ввід даних з консолі (`Console.ReadLine`), перетворення типів (`int.Parse`), умовні конструкції (`if-else if-else`), оператори порівняння (`==`, `>`).

*   **Operators:**
    *   Призначення: Демонструє роботу базових арифметичних операторів у C#: додавання (`+`), віднімання (`-`), множення (`*`), ділення (`/`). Особлива увага приділяється діленню цілих чисел та діленню з плаваючою комою (використання `double`).
    *   Ключові концепції: Арифметичні оператори, цілочисельне ділення, перетворення типів (`(double)`), вивід результатів.

*   **Output:**
    *   Призначення: Найпростіші приклади виведення тексту та значень змінних на консоль за допомогою `Console.WriteLine()`.
    *   Ключові концепції: `Console.WriteLine()`, базовий синтаксис C#.

*   **ParityCheck:**
    *   Призначення: Програма запитує число у користувача і перевіряє, чи є воно парним або непарним, використовуючи оператор залишку від ділення (`%`).
    *   Ключові концепції: Ввід даних, `int.Parse`, оператор залишку (`%`), `if-else`.

*   **ScoreToGrade:**
    *   Призначення: Програма отримує від користувача кількість балів (оцінку) і перетворює її на літерну оцінку (A, B, C) або повідомляє про нескладання іспиту за заданими критеріями.
    *   Ключові концепції: Ввід даних, `int.Parse`, логічні оператори (`&&` - "І"), складні умови в `if-else if-else`.

*   **Testing:**
    *   Призначення: Проект черновик/пісочниця.
    *   Ключові концепції: Тестувались всі вище перечислені концепції.
# My first C# exercises (Day 1-2)

This repository contains a collection of small console programs created while learning the basics of the C# programming language. Each project is in a separate folder and demonstrates certain concepts.

## Projects

Here is a brief description of each project:

* **InterpolationAndTernary:**
    * Purpose: Demonstrates the use of string interpolation (`$“{variable}”`) for easy output formatting and the ternary operator (`condition ? value1 : value2`) for shortened condition writing.
    * Key concepts: Console output, string interpolation, ternary operator.

* **NumberComparison:**
    * Purpose: The program asks the user for two numbers and compares them, displaying which number is greater or reporting that they are equal.
    * Key Concepts: Input from the console (`Console.ReadLine`), type conversion (`int.Parse`), conditional statements (`if-else if-else`), comparison operators (`==`, `>`).

* **Operators:**
    * Purpose: Demonstrates how basic arithmetic operators work in C#: addition (`+`), subtraction (`-`), multiplication (`*`), division (`/`). Special attention is paid to integer division and floating point division (using `double`).
    * Key concepts: Arithmetic operators, integer division, type conversion (`(double)`), output.

* **Output:**
    * Purpose: Simple examples of outputting text and variable values to the console using `Console.WriteLine()`.
    * Key concepts: `Console.WriteLine()`, basic C# syntax.

* **ParityCheck:**
    * Purpose: The program prompts the user for a number and checks whether it is even or odd using the remainder of division operator (`%`).
    * Key concepts: Data input, `int.Parse`, remainder operator (`%`), `if-else`.

* **ScoreToGrade:**
    * Purpose: The program receives the number of points (score) from the user and converts it to a letter grade (A, B, C) or reports a failure according to the specified criteria.
    * Key concepts: Data input, `int.Parse', logical operators (`&&' - “AND”), complex conditions in `if-else if-else'.

* **Testing:**
    * Assignment: Draft/sandbox project.
    * Key concepts: All of the above concepts were tested.
