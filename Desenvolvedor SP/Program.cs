using System;

namespace Desenvolvedor_SP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("1)Soma");
            int indice = 13;
            int soma = 0;
            int k = 0;

            while (k < indice)
            {
                k = k + 1;
                soma = soma + k;
            }

            Console.WriteLine("O valor da variável  soma é " + soma);
            Console.WriteLine();



            // 2
            Console.WriteLine("2)Fibonacci");
            int n1 = -1;
            int n2 = 1;
            int cont = 0;
            int limite = 10;

            while (cont < limite)
            {
                int n3 = n1 + n2;
                n1 = n2;
                n2 = n3;

                Console.WriteLine(n3);
                cont++;
            }
            Console.WriteLine();



            //4
            Console.WriteLine("4)Porcentagem");
            decimal sp = 6783643;
            decimal rj = 3667866;
            decimal mg = 2922988;
            decimal es = 2716548;
            decimal outros = 1984953;
            decimal total = sp + rj + mg + es + outros;

            Console.WriteLine($"Total = {total}");

            sp = ((sp * 100) / total);
            rj = ((rj * 100) / total);
            mg = ((mg * 100) / total);
            es = ((es * 100) / total);
            outros = ((outros * 100) / total);

            Console.WriteLine($"Porcentagem de SP {sp}");
            Console.WriteLine($"Porcentagem de RJ {rj}");
            Console.WriteLine($"Porcentagem de MG {mg}");
            Console.WriteLine($"Porcentagem de ES {es}");
            Console.WriteLine($"Porcentagem de Outros {outros}");
            Console.WriteLine();



            //5
            Console.WriteLine("5)Palavra invertida");
            Console.WriteLine("Digite uma palavra");

            string palavra = Console.ReadLine();
            char[] palavraInvertida = new char[palavra.Length];

            int x = palavra.Length - 1;
            char c;
            int cont1 =0 ;

            for (int i = 0; i < palavra.Length; i++)
            {
                c = palavra[x--];
                palavraInvertida[cont1] = c;
                cont1++;
            }

            Console.WriteLine(palavraInvertida);


        }
    }
}
