int[] CreateArray(int m, int n)
{
    if (m < 1 || n < 1)
    {
        Console.Write("Одно или оба числа не натуральные");
        Environment.Exit(0);
    }
    int[] array = new int[n - m + 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = m + i;
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write($"|\t");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.Write("|");
    Console.WriteLine();
}

int InputVariable(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumArrayElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i];
    }
    return sum;
}

int m = InputVariable("Введите нижнюю границу натуральных чисел: ");
int n = InputVariable("Введите верхнюю границу натуральных чисел: ");

int[] array = CreateArray(m, n);

PrintArray(array);
Console.WriteLine($"Сумма элементов массива = {SumArrayElements(array)}");
