using System;
public static class Ex8
{
    public static void CalcularIMC()
    {
        Console.Write("Peso (kg): "); double peso = double.Parse(Console.ReadLine());
        Console.Write("Altura (m): "); double altura = double.Parse(Console.ReadLine());
        double imc = peso / (altura * altura);
        Console.WriteLine($"IMC: {imc:F1}");
        if (imc < 18.5) Console.WriteLine("Abaixo do peso");
        else if (imc < 25) Console.WriteLine("Peso normal");
        else if (imc < 30) Console.WriteLine("Sobrepeso");
        else Console.WriteLine("Obesidade");
    }
}