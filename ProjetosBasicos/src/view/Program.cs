using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ProjetosBasicosConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("======================================");
                Console.WriteLine("Escolha um exercício para executar:");
                Console.WriteLine("1 - Validador de Senhas Fortes");
                Console.WriteLine("2 - Tabuada Completa");
                Console.WriteLine("3 - Cálculo de Fatorial");
                Console.WriteLine("4 - Conversor de Temperaturas");
                Console.WriteLine("5 - Verificador de Palíndromos");
                Console.WriteLine("6 - Cadastro Simples de Produtos");
                Console.WriteLine("7 - Soma de Números Pares");
                Console.WriteLine("8 - Cálculo de IMC");
                Console.WriteLine("9 - Jogo da Adivinhação");
                Console.WriteLine("10 - Lista de Tarefas (To-Do List)");
                Console.WriteLine("0 - Sair\n");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Ex1.ValidadorSenha();
                        break;
                    case "2":
                        Ex2.Tabuada();
                        break;
                    case "3":
                        Ex3.Fatorial();
                        break;
                    case "4":
                        Ex4.ConversorTemperaturas();
                        break;
                    case "5":
                        Ex5.VerificarPalindromo();
                        break;
                    case "6":
                        Ex6.CadastroProdutos();
                        break;
                    case "7":
                        Ex7.SomarPares();
                        break;
                    case "8":
                        Ex8.CalcularIMC();
                        break;
                    case "9":
                        Ex9.JogoAdivinhacao();
                        break;
                    case "10":
                        Ex10.ListaDeTarefas();
                        break;
                    case "0":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}