using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal n1, n2, n3, n4, result;
            string nome;
            Console.WriteLine("Digite seu nome: \n");
            nome = Console.ReadLine();
            Console.WriteLine("Entre com as notas \n");
            n1 = decimal.Parse(Console.ReadLine());
            n2 = decimal.Parse(Console.ReadLine());
            n3 = decimal.Parse(Console.ReadLine());
            n4 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Resultado: \n");
            result = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("O aluno " + nome + "teve a média de: " + result);
        
        }
    }
}
