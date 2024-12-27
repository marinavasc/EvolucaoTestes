// using System;
// using System.Data.Common;
// using System.Security.Cryptography.X509Certificates;
// namespace EvolucaoTestes.IRPF;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("\nOlá! Quantos contribuintes iremos calcular? ");
//         string num = Console.ReadLine()!;

//         try
//         {
//             if (num == "0")
//             {
//                 Console.WriteLine("\nDigite um valor válido.\nPressione qualquer tecla para voltar.");
//                 Console.ReadKey();
//                 Main(args);
//             }
//             else if (double.TryParse(num, out double num2))
//             {
//                 for (int i = 0; i < num2; i++)
//                 {
//                     AnalisarNome analisar = new AnalisarNome("", 0);
//                     analisar.ReceberNome();

//                     double SalBruto = analisar.SalBruto;
//                     string Nome = analisar.Nome;

//                     CalculoImpostoRenda calculo = new CalculoImpostoRenda();
//                     calculo.CalcularImpostoRenda(SalBruto, Nome);

//                     System.Console.WriteLine($"Nome: {analisar.Nome}");
//                     System.Console.WriteLine($"Salário bruto: {analisar.SalBruto.ToString("C2")}");
//                     System.Console.WriteLine($"Salário líquido: {calculo.salLiquido.ToString("C2")}");
//                     System.Console.WriteLine($"Imposto: {calculo.desconto.ToString("C2")}");
//                 }

//                 Console.WriteLine("\nSe deseja voltar ao íncio para calcular mais um contribuinte, digite 'sim'. \nCaso contrário, só digitar qualquer outra coisa. ");
//                 string sim = Console.ReadLine()!;
//                 if (sim == "sim") Main(args);

//             }
//         }
//         catch (Exception)
//         {
//             Console.WriteLine("\nDigite um valor válido.\nPressione qualquer tecla para voltar.");
//             Console.ReadKey();
//             Main(args);
//         }
//     }
// }

// ﻿using System;
// using System.Security.Cryptography.X509Certificates;
// namespace EvolucaoTestes.IRPF;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("\nOlá! Quantos contribuintes iremos calcular? ");
//         string num = Console.ReadLine()!;

//         if (double.TryParse(num, out double num2))
//         {
//             for (int i = 0; i < num2; i++)
//                 {
//                     AnalisarNome analisar = new AnalisarNome("", 0);
//                     analisar.ReceberNome();

//                     double SalBruto = analisar.SalBruto;
//                     string Nome = analisar.Nome;

//                     CalculoImpostoRenda calculo = new CalculoImpostoRenda();
//                     calculo.CalcularImpostoRenda(SalBruto, Nome);

//                     System.Console.WriteLine($"Nome: {analisar.Nome}");
//                     System.Console.WriteLine($"Salário bruto: {analisar.SalBruto.ToString("C2")}");
//                     System.Console.WriteLine($"Salário líquido: {calculo.salLiquido.ToString("C2")}");
//                     System.Console.WriteLine($"Imposto: {calculo.desconto.ToString("C2")}");
//                 }
//         }
//         else if (num == "0")
//         {
//             Console.WriteLine("\nDigite um valor válido.\nPressione qualquer tecla para voltar.");
//             Console.ReadKey();
//             Main(args);
//         }
//         else
//         {
//             Console.WriteLine("\nDigite um valor válido.\nPressione qualquer tecla para voltar.");
//             Console.ReadKey();
//             Main(args);

//         }
//     }

// }

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
                AnalisarNome analisar = new AnalisarNome("", 0);
                analisar.ReceberNome();

                double SalBruto = analisar.SalBruto;
                string Nome = analisar.Nome;

                CalculoImpostoRenda calculo = new CalculoImpostoRenda();
                calculo.CalcularImpostoRenda(SalBruto, Nome);

                System.Console.WriteLine($"\nNome: {analisar.Nome}");
                System.Console.WriteLine($"Salário bruto: {analisar.SalBruto.ToString("C2")}");
                System.Console.WriteLine($"Salário líquido: {calculo.salLiquido.ToString("C2")}");
                System.Console.WriteLine($"Imposto: {calculo.desconto.ToString("C2")}");

            }
            System.Console.WriteLine("\nSe deseja voltar ao íncio para calcular mais um contribuinte, digite 'sim'. \nCaso contrário, só digitar qualquer outra coisa. ");
            string sim = Console.ReadLine()!;
            if (sim == "sim")
            { Main(args); }
        }
        else
        {
            Console.WriteLine("\nDigite um valor válido.\nPressione qualquer tecla para voltar.");
            Console.ReadKey();
            Main(args);

        }
    }

}