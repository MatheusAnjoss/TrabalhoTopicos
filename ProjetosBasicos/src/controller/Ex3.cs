public static class Ex3
{
    public static void Fatorial()
    {
        Console.Write("Digite um número positivo: "); int n = int.Parse(Console.ReadLine());
        int fat = 1, i = 1; while (i <= n) fat *= i++;
        Console.WriteLine($"Fatorial de {n} é {fat}");
    }
}