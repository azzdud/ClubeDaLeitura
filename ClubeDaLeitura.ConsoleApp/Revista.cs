using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class Revista
    {        
        public static string[] nomeRevista = new string[10];
        public static string[] tipoColecao = new string[10];
        public static string[] numeroEdicao = new string[10];
        public static string[] anoRevista = new string[10];
        public static string[] caixaRevista = new string[10];
        public static int posicaoRevista = 1;

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
                Console.WriteLine("Digite 2 para VISUALIZAR AS REVISTAS CADASTRADAS");
                Console.WriteLine("Digite S para VOLTAR");
                opcaoMenuRevistas = Console.ReadLine();

                if (opcaoMenuRevistas == "1")
                {
                    CadastroRevistas();
                }
                else if (opcaoMenuRevistas == "2")
                {
                    VisualizarRevistas();
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

            Console.Write("\nDigite o NOME DA REVISTA: ");
            nomeRevista[posicaoRevista] = Console.ReadLine();
            Console.Write("Digite o TIPO DE COLEÇÃO: ");
            tipoColecao[posicaoRevista] = Console.ReadLine();
            Console.Write("Digite o NÚMERO DA EDIÇÃO: ");
            numeroEdicao[posicaoRevista] = Console.ReadLine();
            Console.Write("Digite o ANO DA REVISTA: ");
            anoRevista[posicaoRevista] = Console.ReadLine();
            Console.Write("Digite a CAIXA ONDE A REVISTA ESTÁ GUARDADA: ");
            caixaRevista[posicaoRevista] = Console.ReadLine();

            posicaoRevista++;

            Mensagens.ApresentarMensagemSucesso(); 
            Console.ReadKey();
            Console.Clear();
        }
        public static void VisualizarRevistas()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"  _   _        _  __  _   _ ");
            Console.WriteLine(@" /_/ /_`| / / /_` /  /_/ /_`");
            Console.WriteLine(@"/ \ /_, |/ / ._/ /  / / ._/ ");
            Console.ResetColor();

            Console.Clear();
            Console.WriteLine("Visualizando equipamentos");

            for (int posicao = 1; posicao < 10; posicao++)
            {
                if (nomeRevista[posicao] != null)
                {
                     Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nNúmero no índice: " + posicao);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\nNOME DA REVISTA: " + nomeRevista[posicaoRevista]);
                    Console.Write("\nTIPO DE COLEÇÃO: " + tipoColecao[posicaoRevista]);
                    Console.Write("\nNÚMERO DA EDIÇÃO: " + numeroEdicao[posicaoRevista]);
                    Console.Write("\nANO DA REVISTA: " + anoRevista[posicaoRevista]);
                    Console.Write("\nCAIXA ONDE A REVISTA ESTÁ GUARDADA: " + caixaRevista[posicaoRevista]);
                    Console.WriteLine(" ");
                    Console.ResetColor();

                    Mensagens.ApresentarMensagemSucesso();
                    Console.ReadKey();
                    Console.Clear();
                }                
            }
        }
    }
}
                    /*Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nNúmero no índice: " + posicao);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\nDigite o NOME DA REVISTA: ");
                    nomeRevista[posicaoRevista] = Console.ReadLine();
                    Console.Write("Digite o TIPO DE COLEÇÃO: ");
                    tipoColecao[posicaoRevista] = Console.ReadLine();
                    Console.Write("Digite o NÚMERO DA EDIÇÃO: ");
                    numeroEdicao[posicaoRevista] = Console.ReadLine();
                    Console.Write("Digite o ANO DA REVISTA: ");
                    anoRevista[posicaoRevista] = Console.ReadLine();
                    Console.Write("Digite a CAIXA ONDE A REVISTA ESTÁ GUARDADA: ");
                    caixaRevista[posicaoRevista] = Console.ReadLine();
                    Console.ResetColor();

                    Mensagens.ApresentarMensagemSucesso();
                    Console.ReadKey();
                    Console.Clear();*/