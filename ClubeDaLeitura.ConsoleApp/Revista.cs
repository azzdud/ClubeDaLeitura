using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class Revista
    {
        static string tipoColecao, numeroEdicao, anoRevista, caixaRevista;

        public static string MenuRevista()
        {
            string opcaoMenuRevistas;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(@"  _   _        _  __  _   _ ");
                Console.WriteLine(@" /_/ /_`| / / /_` /  /_/ /_`");
                Console.WriteLine(@"/ \ /_, |/ / ._/ /  / / ._/ ");
                Console.ResetColor();

                Console.WriteLine("\nDigite 1 para CADASTRAR UMA REVISTA");
                Console.WriteLine("Digite S para VOLTAR");
                opcaoMenuRevistas = Console.ReadLine();

                if (opcaoMenuRevistas == "1")
                {
                    CadastroRevistas();
                }
                else if (opcaoMenuRevistas == "s" || opcaoMenuRevistas == "S")
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
            } while (opcaoMenuRevistas != "1");

            return opcaoMenuRevistas;

        }
        public static void CadastroRevistas()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"  _   _        _  __  _   _ ");
            Console.WriteLine(@" /_/ /_`| / / /_` /  /_/ /_`");
            Console.WriteLine(@"/ \ /_, |/ / ._/ /  / / ._/ ");
            Console.ResetColor();

            Console.Write("\nDigite o TIPO DE COLEÇÃO: ");
            tipoColecao = Console.ReadLine();
            Console.Write("Digite o NÚMERO DA EDIÇÃO: ");
            numeroEdicao = Console.ReadLine();
            Console.Write("Digite o ANO DA REVISTA: ");
            anoRevista = Console.ReadLine();
            Console.Write("Digite a CAIXA ONDE A REVISTA ESTÁ GUARDADA: ");
            caixaRevista = Console.ReadLine();

            Mensagens.ApresentarMensagemSucesso();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
