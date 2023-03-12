using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disciplina
{
    internal class Aluno
    {
        public string ra;
        public string nome;
        public decimal notaprova;
        public decimal notatrabalho;
        public decimal notaprova2;
        public decimal notatrabalho2;
        private decimal notafinal;
        private decimal notatotal;


        public void CalcularMedia()
        {
            notatotal = (notaprova + notatrabalho + notaprova2 + notatrabalho2);
            notafinal = notatotal / 2;
        }
        public bool CalcularNotaFinal()
        {
            
            decimal valorpassar = 14;
            if ((notatotal) < valorpassar)
            {
                Console.WriteLine("Aluno Reprovado!");
                Console.WriteLine("Nota necessaria para prova final: " + (12 - (notafinal)));
                return true;
            }
            else
            {
                Console.WriteLine("Aluno Aprovado!");
                return false;
            }

        }
        public void ImprimirNotaFinal()
        {
            Console.WriteLine($"Nota do(a) aluno(a) {nome} no Periodo: {(notatotal).ToString("N2")}");
        }
        public void ReceberDados()
        {
            Console.Write("Digite o RA: ");
            ra = Console.ReadLine();
            Console.Write("Digite o Nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o valor da Prova: ");
            notaprova = Decimal.Parse(Console.ReadLine());
            Console.Write("Digite o valor da Prova 2: ");
            notaprova2 = Decimal.Parse(Console.ReadLine());
            Console.Write("Digite o valor do Trabalho: ");
            notatrabalho = Decimal.Parse(Console.ReadLine());
            Console.Write("Digite o valor do Trabalho 2: ");
            notatrabalho2 = Decimal.Parse(Console.ReadLine());

        }
    }
}
