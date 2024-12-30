using System;
using System.Security.Cryptography.X509Certificates;
namespace EvolucaoTestes.IRPF;

class Program
{
    static void Main(string[] args)
    {
 Console.Write("\nOlá! Quantos contribuintes iremos calcular? ");
        if (double.TryParse(Console.ReadLine(), out double numContribuintes) && numContribuintes > 0)
        {
            for (int i = 0; i < numContribuintes; i++)
            {
                string nome;
                do
                {
                    Console.Write("\nQual seu nome? ");
                    nome = Console.ReadLine()!;
                } while (!AnalisarNome.ValidarNome(nome));

                double SalBruto;
                do
                {
                    Console.Write("E qual seu salário bruto? ");
                } while (!AnalisarSalario.ValidarSalario(Console.ReadLine(), out SalBruto));

                CalculoImpostoRenda calculo = new CalculoImpostoRenda();
                calculo.CalcularImpostoRenda(SalBruto);

                Console.WriteLine($"\nNome: {nome}");
                Console.WriteLine($"Salário bruto: {SalBruto.ToString("C2")}");
                Console.WriteLine($"Salário líquido: {calculo.SalLiquido.ToString("C2")}");
                Console.WriteLine($"Imposto: {calculo.Desconto.ToString("C2")}");
            }
        }
        else
        {
            Console.WriteLine("\nDigite um valor válido.");
        }
    }
}