using System;
public static class Ex4
{
    public static void ConversorTemperaturas()
    {
        bool ativo = true;
        while (ativo)
        {
            Console.WriteLine("\n1 - Celsius para Fahrenheit\n2 - Fahrenheit para Celsius\n3 - Sair");
            string op = Console.ReadLine();
            switch (op)
            {
                case "1":
                    Console.Write("Celsius: "); double c = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Fahrenheit: {c * 9 / 5 + 32}"); break;
                case "2":
                    Console.Write("Fahrenheit: "); double f = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Celsius: {(f - 32) * 5 / 9}"); break;
                case "3": ativo = false; break;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
    }
}