using System;
using System.Security.Cryptography.X509Certificates;
namespace EvolucaoTestes.IRPF;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Olá! Quantos contribuintes iremos calcular? ");
        int num = int.Parse(Console.ReadLine()!);
        try
        {
           for (int i = 0; i < num; i++)
            {

            var analisar = new AnalisarDados("", 0);
            analisar.ReceberDados();

            var calculo = new CalculoImpostoRenda(analisar.SalBruto);

            Console.WriteLine($"\nContribuinte: {analisar.Nome}");
            Console.WriteLine($"Salário bruto: {calculo.SalBruto}");
            Console.WriteLine($"Salário Líquido: {calculo.SalLiquido}");
            Console.WriteLine($"Imposto Descontado: {calculo.Desconto}");

            }
        }
        catch
        {
            Console.WriteLine("Digite um valor válido.");
        }
        
    }
}