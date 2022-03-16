using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Caixas
    {
        static string corCaixa, etiquetaCaixa, numeroCaixa;

        public static string MenuCaixas()
        {
            string opcaoMenuCaixas;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(@"  _   _          _   _ ");
                Console.WriteLine(@" / ` /_/ / \ /  /_/ /_`");
                Console.WriteLine(@"/_, / / /  /'\ / / ._/ ");
                Console.ResetColor();

                Console.WriteLine("\nDigite 1 para CADASTRAR UMA CAIXA");
                Console.WriteLine("Digite S para VOLTAR");
                opcaoMenuCaixas = Console.ReadLine();

                if (opcaoMenuCaixas == "1")
                {
                    CadastroCaixas();
                }
                else if (opcaoMenuCaixas == "s" || opcaoMenuCaixas == "S")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Mensagens.ApresentarMensagemErro();
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (opcaoMenuCaixas != "1");

            return opcaoMenuCaixas;

        }
        public static void CadastroCaixas()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@"  _   _          _   _ ");
            Console.WriteLine(@" / ` /_/ / \ /  /_/ /_`");
            Console.WriteLine(@"/_, / / /  /'\ / / ._/ ");
            Console.ResetColor();

            Console.Write("\nDigite a ETIQUETA DA CAIXA: ");
            etiquetaCaixa = Console.ReadLine();
            Console.Write("Digite a COR DA CAIXA: ");
            corCaixa = Console.ReadLine();
            Console.Write("Digite o NÚMERO DA CAIXA: ");
            numeroCaixa = Console.ReadLine();

            Mensagens.ApresentarMensagemSucesso();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
