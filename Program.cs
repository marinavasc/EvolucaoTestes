using System;
using System.Security.Cryptography.X509Certificates;
namespace EvolucaoTestes.IRPF;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("\nOlá! Quantos contribuintes iremos calcular? ");
        string num = Console.ReadLine()!;

        if (double.TryParse(num, out double num2) && num2 > 0)
        {
            for (int i = 0; i < num2; i++)
            {
                Console.Write("\nQual seu nome? ");
                string nome = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(nome))
                {
                    System.Console.WriteLine("\nDigite um nome válido.\nPressione qualquer tecla para voltar.");
                    Console.ReadKey();
                    Main(args);
                }

                Console.Write("E qual seu salário bruto? ");
                string salBrutoString = Console.ReadLine()!;
                if (double.TryParse(salBrutoString, out double salBruto))
                {
                    AnalisarNome analisar = new AnalisarNome(nome);
                    analisar.ReceberNome();
                    
                    AnalisarSalario salario = new AnalisarSalario();
                    double SalBruto = salario.SalBruto;
                    salario.ReceberSalario(SalBruto);

                    string Nome = analisar.Nome;

                    CalculoImpostoRenda calculo = new CalculoImpostoRenda();
                    calculo.CalcularImpostoRenda(SalBruto, Nome);

                    System.Console.WriteLine($"\nNome: {analisar.Nome}");
                    System.Console.WriteLine($"Salário bruto: {salario.SalBruto.ToString("C2")}");
                    System.Console.WriteLine($"Salário líquido: {calculo.salLiquido.ToString("C2")}");
                    System.Console.WriteLine($"Imposto: {calculo.desconto.ToString("C2")}");

                }
                System.Console.WriteLine("\nSe deseja voltar ao íncio para calcular mais um contribuinte, digite 'sim'. \nCaso contrário, só digitar qualquer outra coisa. ");
                string sim = Console.ReadLine()!;
                if (sim == "sim")
                { Main(args); }
            }
        }
        else
        {
            Console.WriteLine("\nDigite um valor válido.\nPressione qualquer tecla para voltar.");
            Console.ReadKey();
            Main(args);
        }
    }

}