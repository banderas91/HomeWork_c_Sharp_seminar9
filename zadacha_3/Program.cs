// /* Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. */


Console.Write("Введите неотрицательное число М: ");
 int m = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите неотрицательное число N: ");
 int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0)
        {
            return Akkerman(m - 1, 1);
        }
        else 
        {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
    }
}
Console.Write("Результат вычисления функции Аккермана ====> ");
Console.WriteLine(Akkerman(m, n));