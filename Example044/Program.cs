// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите колличество символов");
int number = int.Parse(Console.ReadLine()!);

int[] array = new int[number];

array[0] = 0;
array[1] = 1;
for (int i = 2; i < array.Length; i++)
{
    array[i] = array[i - 1] + array[i - 2];
}
Console.WriteLine(string.Join(" ", array));

// Второй вариант

void Check(int n)
{
    int numberOne = 0;
    int numberTwo = 1;
    for (int i = 0; i < n; i++)
    {
        Console.Write(numberOne + " ");
        int x = numberOne + numberTwo;
        numberOne = numberTwo;
        numberTwo = x;
    }
}
Console.WriteLine("Введите колличество символов");
int n = int.Parse(Console.ReadLine()!);
Check(n);

// Вариант Ивана

Console.WriteLine("Введите число: ");
int number = int.ToInt32(Console.ReadLine());

int Fibonnachi = new int[number];

Fibonnachi[0] = 0;
Fibonnachi[1] = 1;
for (int i = 2;  i < Fibonnachi.Length; i++);
{
    Fibonnachi[i] = Fibonnachi[i - 1] + Fibonnachi[i - 2];
}
Console.WriteLine(string.Join(" ", Fibonnachi));