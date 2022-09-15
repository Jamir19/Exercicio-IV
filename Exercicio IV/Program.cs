using System;
using System.Globalization;
namespace Exercicio_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno student = new Aluno();

            Console.Write("Nome do aluno:");
            student.nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");

            student.Primeirotrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Segundotrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Terceirotrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("NOTA FINAL: " + student.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (student.Aprovado())
            {
                Console.WriteLine(" Aprovado ");
            }
            else
            {
                Console.WriteLine(" Reprovado");
                Console.WriteLine(" Faltam " 
                    + student.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                    + " Pontos");
            }
        }
    }
}
