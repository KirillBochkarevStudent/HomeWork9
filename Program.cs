// Метод для ввода числа:
int Input(string text)
{
    Console.Write(text);
    int rezult = Convert.ToInt32(Console.ReadLine());
    return rezult;
}

// Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
void Task64()
{
    int M = Input("Введите число М: ");
    int N = Input("Введите число N: ");
    int i = M;
    void Recursion(int M, int N, int i)
    {
        if (i > N) return;
        if (i % 3 == 0)
        {
            Console.Write(i + ", ");
        }
        i++;
        Recursion(M, N, i);
    }
    Recursion(M, N, i);
}

// Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.
void Task66()
{
    int M = Input("Введите число М: ");
    int N = Input("Введите число N: ");
    int sum = 0;
    int i = M;
    void Recursion(int M, int N, int sum, int i)
    {
        if (i > N) 
        {
            Console.WriteLine ($"Сумма натуральных элементов равна: {sum}");
            return;
        }
        else
        {
            if (i > 0)
            {
                sum = sum + i;
            }
            else
            {
                sum = sum;
            }
            i++;
            Recursion(M, N, sum, i);
        }
    }
    Recursion(M, N, sum, i);
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
void Task68()
{
    double m = Input("Введите число m: ");
    double n = Input("Введите число n: ");
    double A = 0;
    double Recursion(double m, double n)
    {
        if (m == 0)
        {
            A = n + 1;
            return A;
        }
        if (n == 0)
        {
            A = Recursion(m - 1, 1);
            return A;
        }
        if (m > 0 && n > 0)
        {
            A = Recursion(m - 1, Recursion(m, n - 1));
            return A;
        }
        else
        {
            return A;
        }
    }
    Recursion(m, n);
    Console.WriteLine($"A(m,n) = {A}");
}

// Для выбора программы:
Console.WriteLine("Выберите программу:");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 64)
{
    Task64();
}
else if (number == 66)
{
    Task66();
}
else if (number == 68)
{
    Task68();
}
else
{
    Console.WriteLine("Ошибка (такой программы не существует)");
}
