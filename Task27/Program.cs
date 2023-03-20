Console.Clear();
Console.Write("Введите число: ");
string s = Console.ReadLine()!;
int sum = 0;

for (int i = 0; i < s.Length; i++)
    sum = sum + int.Parse(s[i].ToString());
Console.WriteLine($"сумма цифр числа {sum}");