using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Mensagens
    {        
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
