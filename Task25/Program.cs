Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 число: ");
int m = int.Parse(Console.ReadLine()!);
for (int i = 2; i < m; i++)
    m = m * i;
    Console.WriteLine($"{n}");