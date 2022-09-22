int AckermannFunction(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return AckermannFunction(n - 1, 1);
    if (n > 0 && m > 0) return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
    return AckermannFunction(n, m);
}

int InputVariable(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int m = InputVariable("Введите первое неотрицательное натуральное чисел: ");
int n = InputVariable("Введите второе неотрицательное натуральное чисел: ");

Console.WriteLine($"Вычисление функции Аккермана = {AckermannFunction(m, n)}");