using System;
public static class Ex9
{
    public static void JogoAdivinhacao()
    {
        Random rnd = new Random(); int num = rnd.Next(1, 101), tentativas = 0, chute = 0;
        Console.WriteLine("Adivinhe o número entre 1 e 100");
        while (chute != num)
        {
            Console.Write("\nSeu palpite: "); chute = int.Parse(Console.ReadLine()); tentativas++;
            if (chute < num) Console.WriteLine("Maior");
            else if (chute > num) Console.WriteLine("Menor");
        }
        Console.WriteLine($"\nAcertou em {tentativas} tentativas!");
    }
}