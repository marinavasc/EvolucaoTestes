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
                System.Console.WriteLine("Qual seu nome? ");
                string nome = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(nome))
                {
                    System.Console.WriteLine("Nome inválido. Digite novamente.");
                    i--;
                    // voltar ao inicio
                    break;
                }

                AnalisarNome novoNome = new AnalisarNome(nome);
                novoNome.ReceberNome(nome);

                System.Console.WriteLine("Qual seu salário bruto? ");
                AnalisarSalario salario = new AnalisarSalario();
                double SalBruto = double.Parse(Console.ReadLine()!);
                salario.ReceberSalario(SalBruto);

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
            // voltar ao inicio
        }
    }
}