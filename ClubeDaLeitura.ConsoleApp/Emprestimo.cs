using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Emprestimo
    {
        static string nomeUsuario, revistaEmprestada, dataEmprestimo, dataDevolucaoEmprestimo;

        public static string MenuEmprestimos()
        {
            string opcaoMenuEmprestimos;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(@"  _        _   _   _   _  __         _   _ ");
                Console.WriteLine(@" /_` /|,/ /_/ /_/ /_` /_` /  / /|,/ / / /_`");
                Console.WriteLine(@"/_, /  / /   / \ /_, ._/ /  / /  / /_/ ._/ ");
                Console.ResetColor();

                Console.WriteLine("\nDigite 1 para CADASTRAR UM EMPRÉSTIMO");
                Console.WriteLine("Digite S para VOLTAR");
                opcaoMenuEmprestimos = Console.ReadLine();

                if (opcaoMenuEmprestimos == "1")
                {
                    CadastroEmprestimos();
                }
                else if (opcaoMenuEmprestimos == "s" || opcaoMenuEmprestimos == "S")
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
            } while (opcaoMenuEmprestimos != "1");

            return opcaoMenuEmprestimos;

        }
        public static void CadastroEmprestimos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"  _        _   _   _   _  __         _   _ ");
            Console.WriteLine(@" /_` /|,/ /_/ /_/ /_` /_` /  / /|,/ / / /_`");
            Console.WriteLine(@"/_, /  / /   / \ /_, ._/ /  / /  / /_/ ._/ ");
            Console.ResetColor();

            Console.Write("\nDigite o NOME DO USUÁRIO: ");
            nomeUsuario = Console.ReadLine();
            Console.Write("Digite QUAL A REVISTA EMPRESTADA: ");
            revistaEmprestada = Console.ReadLine();
            Console.Write("Digite a DATA DO EMPRÉSTIMO: ");
            dataEmprestimo = Console.ReadLine();
            Console.Write("Digite a DATA DE DEVOLUÇÃO: ");
            dataDevolucaoEmprestimo = Console.ReadLine();

            Mensagens.ApresentarMensagemSucesso();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
