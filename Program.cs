using System;
using System.Security.Cryptography.X509Certificates;
namespace EvolucaoTestes.IRPF;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Olá! Quantos contribuintes iremos calcular? ");
        string num = Console.ReadLine()!;

        if (double.TryParse(num, out double result))
        {
            for (int i = 0; i < result; i++)
            {
                AnalisarDados analisar = new AnalisarDados("", 0);
                analisar.ReceberDados();

                CalculoImpostoRenda calculo = new CalculoImpostoRenda();
                calculo.CalcularImpostoRenda(analisar.SalBruto, analisar.Nome);
            }
        }
        else
        {
            // Console.WriteLine("Digite um valor válido.");
            Console.WriteLine("\nDigite um valor válido.\nPressione qualquer tecla para voltar.\n");
            Console.ReadKey();
            Main(args);

        }
    }

}


// try
// {
//     for (int i = 0; i < num; i++)
//     {

//         AnalisarDados analisar = new AnalisarDados("", 0);
//         analisar.ReceberDados();

//         CalculoImpostoRenda calculo = new CalculoImpostoRenda();
//         calculo.CalcularImpostoRenda(analisar.SalBruto, analisar.Nome);


//     }
// }
// catch
// {
//     Console.WriteLine("Digite um valor válido.");
// }
