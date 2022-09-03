Console.WriteLine("Введите число: ");
string Str = Console.ReadLine()!;
char[] array = Str.ToCharArray();
int length = array.Length;
for (int i = 0; i < length-1; i++) Console.Write($"{array[i]}, ");
Console.Write($"{array[^1]}");