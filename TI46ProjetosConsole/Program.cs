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
            // programaMedia();

            //exercicio1();

            exercicio2();

          





        }

        private static void exercicio2()
        {
            //aqui fica o exercício chamado.

        }

        private static void exercicio1()
        {
            //  Exercício 1: Declaração de Variáveis
            //  Declarar três variáveis de tipos
            //  diferentes(inteiro, real e caractere) e atributos

            Console.WriteLine("exercício 1");
            Console.ReadKey();  

        }

        private static void programaMedia()
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

            Console.WriteLine("O aluno " + nome + " teve a média de: " + result);

            Console.ReadKey();
        }
    }
}
