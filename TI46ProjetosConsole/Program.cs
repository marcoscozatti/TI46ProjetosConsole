using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string opcao;

            Lista01 lista01 = new Lista01();
            Lista02 lista02 = new Lista02();    

            do
            {


                //Criando um manu com switch case
                Console.Clear();
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1 - Programa média");
                Console.WriteLine("2 - Exercício 1 da lista");
                Console.WriteLine("3 - Exercício 2 da lista");
                Console.WriteLine("4 - Testemetodo");
                Console.WriteLine("5 - Sair");

                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        lista02.programaMedia();
                        break;

                    case 2:
                        lista01.exercicio1();
                        break;

                    case 3:
                        lista01.exercicio2();
                        break;

                    case 4:
                         
                        lista01.testeMetodo(); 
                        break;
                    case 5:
                        lista02.testeClasse();
                        break;


                    default:
                        Console.WriteLine("Operação inválida.");
                        break;
                }


                Console.WriteLine("Deseja continuar no programa(S/N)");
                opcao = Console.ReadLine().ToUpper();

            } while (opcao == "S");

           


        }

       

      

       

      
    }
}
