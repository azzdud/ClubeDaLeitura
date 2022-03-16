using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Usuario
    {
        static string nomeUsuario, nomeResponsavel, telefoneUsuario, enderecoUsuario;

        public static string MenuUsuarios()
        {
            string opcaoMenuUsuarios;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(@"      _       _   _     _   _ ");
                Console.WriteLine(@" / / /_` / / /_/ /_/ / / / /_`");
                Console.WriteLine(@"/_/ ._/ /_/ / / / \ / /_/ ._/ ");
                Console.ResetColor();

                Console.WriteLine("\nDigite 1 para CADASTRAR UM USUÁRIO");
                Console.WriteLine("Digite S para VOLTAR");
                opcaoMenuUsuarios = Console.ReadLine();

                if (opcaoMenuUsuarios == "1")
                {
                    CadastroUsuarios();
                }
                else if (opcaoMenuUsuarios == "s" || opcaoMenuUsuarios == "S")
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
            } while (opcaoMenuUsuarios != "1");

            return opcaoMenuUsuarios;

        }
        public static void CadastroUsuarios()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"      _       _   _     _   _ ");
            Console.WriteLine(@" / / /_` / / /_/ /_/ / / / /_`");
            Console.WriteLine(@"/_/ ._/ /_/ / / / \ / /_/ ._/ ");
            Console.ResetColor();

            Console.Write("\nDigite o NOME DO USUÁRIO: ");
            nomeUsuario = Console.ReadLine();
            Console.Write("Digite o NOME DO RESPONSÁVEL: ");
            nomeResponsavel = Console.ReadLine();
            Console.Write("Digite o TELEFONE: ");
            telefoneUsuario = Console.ReadLine();
            Console.Write("Digite a ENDEREÇO: ");
            enderecoUsuario = Console.ReadLine();

            Mensagens.ApresentarMensagemSucesso();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
