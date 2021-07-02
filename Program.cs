using System;
using System.Globalization;
using System.Collections.Generic;
namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new();
            Console.WriteLine("1 - Digite um nome");
            Console.WriteLine("2 - Ler nome");
            Console.WriteLine("3 - Insira um nome e altere a lista");
            Console.WriteLine("4 - Excluir nome");
            Console.WriteLine("5 - Lista atualizada");
            Console.WriteLine("6 - Sair");
            Console.WriteLine("Digite qualquer número para continuar");
            int opc = int.Parse(Console.ReadLine()); 
            while (opc != 6)
            {
                Console.Write("Digite a opção desejada:     ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Write("Insira um nome: ");
                        nomes.Add(Console.ReadLine());
                        break;

                    case 2:
                        foreach (string lista in nomes)
                        {
                            Console.WriteLine($"Lista: " + lista);
                        }
                        break;

                    case 3:
                        Console.Write("Insira um nome e altere a lista: ");
                        nomes.Insert(0, Console.ReadLine());
                        break;

                    case 4:
                        Console.Write("Exclua um nome: ");
                        nomes.Remove(Console.ReadLine());
                        break;
                    case 5:
                        foreach (string lista in nomes)
                        {
                            Console.WriteLine(lista);
                        }
                        break;
                    case 6:

                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

    }
}
