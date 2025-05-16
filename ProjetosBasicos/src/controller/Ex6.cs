public class Produto { public string Nome; public double Preco; public int Quantidade; }
public static class Ex6
{
    public static void CadastroProdutos()
    {
        Produto[] produtos = new Produto[3];
        for (int i = 0; i < 3; i++)
        {
            produtos[i] = new Produto();
            Console.Write($"Produto {i + 1} Nome: "); produtos[i].Nome = Console.ReadLine();
            Console.Write("Preço: "); produtos[i].Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: "); produtos[i].Quantidade = int.Parse(Console.ReadLine());
        }
        foreach (var p in produtos)
            Console.WriteLine($"{p.Nome} - Total: R${p.Preco * p.Quantidade:F2}");
    }
}