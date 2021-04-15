using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula12 , Calcular a hipotenusa do triangulo retangulo, tipo double
            //Jonas Valereo - Técnico em Informática 

            //Declarando as variaveis, tipo double

            double h, b, c;

            //Declarando entrada de dado no console, método ReadLine

            Console.WriteLine("Digite o valor do Cateto Oposto: ");
            b = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor do Cateto Adjacente: ");
            c = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //Declarando a variavel hipotenusa do triangulo retangulo

            h = Math.Pow(b, 2.0) + Math.Pow(c, 2.0);


            //imprimir saida de dados no console, e método WhriteLine, concatenação

            Console.WriteLine("A hipotenusa: " + h.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Parabéns, tente de novo!!!");


            // saida da aplicação, console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa

        }
    }
}
