int Sum(string A)
{
    char[] array = A.ToCharArray();
    int result = 0;
        for (int i = 0; i < A.Length; i++) result = result + int.Parse(array[i].ToString());
        return result;
}
Console.WriteLine("Введите число: ");
string Str = Console.ReadLine()!;
Console.WriteLine(Sum(Str));