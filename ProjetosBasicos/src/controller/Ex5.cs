public static class Ex5
{
    public static void VerificarPalindromo()
    {
        Console.Write("Digite uma palavra ou frase: ");
        string entrada = new string(Console.ReadLine()
        .Where(char.IsLetterOrDigit).Select(char.ToLower).ToArray());
        string reverso = new string(entrada.Reverse().ToArray());
        Console.WriteLine(entrada == reverso ? "É palíndromo!" : "Não é palíndromo.");
    }
}