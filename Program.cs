// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9



Console.WriteLine("Введите число M:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int Ankerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return Ankerman(m - 1, 1);
    else
        return Ankerman(m - 1, Ankerman(m, n - 1));

}
Console.Write($"Функция Анкермана равна {Ankerman(number, secondNumber)}");
