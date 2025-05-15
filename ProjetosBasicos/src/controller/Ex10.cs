using System;
using System.Collections.Generic;
public static class Ex10
{
    public static void ListaDeTarefas()
    {
        List<string> tarefas = new List<string>();
        bool ativo = true;
        while (ativo)
        {
            Console.WriteLine("1 - Adicionar Tarefa\n2 - Listar Tarefas\n3 - Sair");
            string op = Console.ReadLine();
            switch (op)
            {
                case "1": Console.Write("\nTarefa: "); tarefas.Add(Console.ReadLine());  Console.WriteLine("\n"); break;
                case "2":
                    Console.WriteLine("Lista de tarefas: ");
                    for (int i = 0; i < tarefas.Count; i++) Console.WriteLine($"\n{i + 1}. {tarefas[i]}\n");
                    break;
                case "3": ativo = false; break;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
    }
}