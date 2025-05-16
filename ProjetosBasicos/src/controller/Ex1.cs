using System.Text.RegularExpressions;
public static class Ex1
{
    public static void ValidadorSenha()
    {
        Console.Write("Digite uma senha: "); string senha = Console.ReadLine();
        bool valida = senha.Length >= 8 && Regex.IsMatch(senha, "[A-Z]") &&
        Regex.IsMatch(senha, "[0-9]") && Regex.IsMatch(senha, "[!@#]");
        Console.WriteLine(valida ? "Senha forte!" : "Senha fraca.");
    }
}