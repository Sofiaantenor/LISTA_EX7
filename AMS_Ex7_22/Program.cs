using System;

namespace AMS_Ex7_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1 = 10;
            double nota2 = 7;
            double nota3 = 9;
            double nota4 = 8;
            double media;

            Console.WriteLine("");
            Console.WriteLine("         ***CÁLCULO DA MÉDIA DE UM ALUNO***      ");

            media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("");

            Console.WriteLine($"A média desse aluno é {media}");
            Console.WriteLine("");

            if (media > 7 )
            {
               Console.WriteLine("                  ALUNO APROVADO!");
            } 
            else
            {
               Console.WriteLine("                  ALUNO REPROVADO!");
            }

            Console.WriteLine("");
        }
    }
}