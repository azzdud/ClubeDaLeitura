using System;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
        }
        
        public static string MenuPrincipal()
        {
            string opcaoMenuPrincipal;

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@"___  ___                          _         _____                                ");
                Console.WriteLine(@"|  \/  |                         | |       |  _  |                               ");
                Console.WriteLine(@"| .  . |  ___  _ __   _   _    __| |  ___  | | | | _ __    ___   ___    ___  ___ ");
                Console.WriteLine(@"| |\/| | / _ \| '_ \ | | | |  / _` | / _ \ | | | || '_ \  / __| / _ \  / _ \/ __|");
                Console.WriteLine(@"| |  | ||  __/| | | || |_| | | (_| ||  __/ \ \_/ /| |_) || (__ | (_) ||  __/\__ \");
                Console.WriteLine(@"\_|  |_/ \___||_| |_| \__,_|  \__,_| \___|  \___/ | .__/  \___| \___/  \___||___/");
                Console.WriteLine(@"                                                  | |                            ");
                Console.WriteLine(@"                                                  |_|                            ");
                Console.ResetColor();
                Console.WriteLine("\nDigite 1 para acessar a seção de REVISTAS");
                Console.WriteLine("Digite 2 para acessar a seção de EMPRÉSTIMOS");
                Console.WriteLine("Digite 3 para acessar a seção de USUÁRIOS");
                Console.WriteLine("Digite 4 para acessar a seção de CAIXAS");
                Console.WriteLine("\nDigite S para SAIR");
                opcaoMenuPrincipal = Console.ReadLine();

                if (opcaoMenuPrincipal == "1")
                {
                    Console.Clear();
                    Revista.MenuRevista();
                }
                else if (opcaoMenuPrincipal == "2")
                {
                    Console.Clear();
                    Emprestimo.MenuEmprestimos();
                }
                else if (opcaoMenuPrincipal == "3")
                {
                    Console.Clear();
                    Usuario.MenuUsuarios();
                }
                else if (opcaoMenuPrincipal == "4")
                {
                    Console.Clear();
                    Caixas.MenuCaixas();
                }
                else if (opcaoMenuPrincipal == "s" || opcaoMenuPrincipal == "S")
                {
                    break;
                }
                else
                {
                    Mensagens.ApresentarMensagemErro();
                    Console.ReadKey();
                    Console.Clear();
                }
                
            }while (opcaoMenuPrincipal != "1" || opcaoMenuPrincipal != "2" || opcaoMenuPrincipal != "3" || opcaoMenuPrincipal != "4");

            return opcaoMenuPrincipal;
        }        
    }
}