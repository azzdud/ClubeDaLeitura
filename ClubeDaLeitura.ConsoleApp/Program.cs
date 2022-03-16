using System;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Program
    {
        static string opcaoMenu;
        static string tipoColecao, numeroEdicao, anoRevista, caixaRevista;
        static string nomeUsuario, revistaEmprestada, dataEmprestimo, dataDevolucaoEmprestimo;
        static string nomeResponsavel, telefoneUsuario, enderecoUsuario;
        static string corCaixa, etiquetaCaixa, numeroCaixa;

        static void Main(string[] args)
        {          
            MenuPrincipal();            
        }

        public class Revista
        {

        }

        public class Emprestimo
        {

        }

        public class Usuario
        {

        }

        public static void MenuPrincipal()
        {
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
                opcaoMenu = Console.ReadLine();

                if (opcaoMenu == "1")
                {
                    Console.Clear();
                    MenuRevista();
                }
                else if (opcaoMenu == "2")
                {
                    Console.Clear();
                    MenuEmprestimos();
                }
                else if (opcaoMenu == "3")
                {
                    Console.Clear();
                    MenuUsuarios();
                }
                else if (opcaoMenu == "4")
                {
                    Console.Clear();
                    MenuCaixas();
                }
                else if (opcaoMenu == "s" || opcaoMenu == "S")
                {
                    return;
                }
                else
                {
                    ApresentarMensagemErro();
                    Console.ReadKey();
                    Console.Clear();
                }
                
            }while (opcaoMenu != "1" || opcaoMenu != "2" || opcaoMenu != "3" || opcaoMenu != "4");
                        
            Console.ReadLine();
        }

        public static void MenuUsuarios()
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(@"      _       _   _     _   _ ");
                Console.WriteLine(@" / / /_` / / /_/ /_/ / / / /_`");
                Console.WriteLine(@"/_/ ._/ /_/ / / / \ / /_/ ._/ ");
                Console.ResetColor();

                Console.WriteLine("\nDigite 1 para CADASTRAR UM USUÁRIO");
                Console.WriteLine("Digite S para VOLTAR");
                opcaoMenu = Console.ReadLine();

                if (opcaoMenu == "1")
                {
                    CadastrarUsuario();
                }
                else if (opcaoMenu == "s" || opcaoMenu == "S")
                {
                    Console.Clear();
                    return;
                }
                else
                {
                    ApresentarMensagemErro();
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (opcaoMenu != "1");

            Console.ReadLine();
            Console.Clear();
        }

        public static void CadastrarUsuario()
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

            ApresentarMensagemSucesso();
        }

        public static void MenuEmprestimos()
        {
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
                opcaoMenu = Console.ReadLine();

                if (opcaoMenu == "1")
                {
                    CadastrarEmprestimo();
                }
                else if (opcaoMenu == "s" || opcaoMenu == "S")
                {
                    Console.Clear();
                    return;
                }
                else
                {
                    ApresentarMensagemErro();
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (opcaoMenu != "1");

            Console.ReadLine();
            Console.Clear();
        }

        public static void CadastrarEmprestimo()
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

            ApresentarMensagemSucesso();
        }

        public static void MenuRevista()
        {
            do
            {                
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(@"  _   _        _  __  _   _ ");
                Console.WriteLine(@" /_/ /_`| / / /_` /  /_/ /_`");
                Console.WriteLine(@"/ \ /_, |/ / ._/ /  / / ._/ ");
                Console.ResetColor();

                Console.WriteLine("\nDigite 1 para CADASTRAR UMA REVISTA");
                Console.WriteLine("Digite S para VOLTAR");
                opcaoMenu = Console.ReadLine();

                if (opcaoMenu == "1")
                {
                    CadastrarRevista();
                }
                else if (opcaoMenu == "s" || opcaoMenu == "S")
                {
                    Console.Clear();
                    return;
                }
                else
                {
                    ApresentarMensagemErro();
                    Console.ReadKey();
                    Console.Clear();
                }                
            } while (opcaoMenu != "1");

            Console.ReadLine();
            Console.Clear();
        }

        public static void CadastrarRevista()
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

            ApresentarMensagemSucesso();
        }

        public static void MenuCaixas()
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(@"  _   _          _   _ ");
                Console.WriteLine(@" / ` /_/ / \ /  /_/ /_`");
                Console.WriteLine(@"/_, / / /  /'\ / / ._/ ");
                Console.ResetColor();

                Console.WriteLine("\nDigite 1 para CADASTRAR UMA CAIXA");
                Console.WriteLine("Digite S para VOLTAR");
                opcaoMenu = Console.ReadLine();

                if (opcaoMenu == "1")
                {
                    CadastrarCaixa();
                }
                else if (opcaoMenu == "s" || opcaoMenu == "S")
                {
                    Console.Clear();
                    return;
                }
                else
                {
                    ApresentarMensagemErro();
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (opcaoMenu != "1");

            Console.ReadLine();
            Console.Clear();
        }

        public static void CadastrarCaixa()
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

            ApresentarMensagemSucesso();
        }

        public static void ApresentarMensagemErro()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nOPÇÃO INVÁLIDA, TENTE NOVAMENTE.\n");
            Console.ResetColor();
        }        

        public static void ApresentarMensagemSucesso()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nOPERAÇÃO REALIZADA COM SUCESSO\n");
            Console.ResetColor();
        }
    }
}