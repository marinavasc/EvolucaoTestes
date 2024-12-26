﻿using System;
using System.Security.Cryptography.X509Certificates;
namespace EvolucaoTestes.IRPF;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("\nOlá! Quantos contribuintes iremos calcular? ");
        string num = Console.ReadLine()!;

        if (double.TryParse(num, out double resultado))
        {
            for (int i = 0; i < resultado; i++)
            {
                AnalisarNome analisar = new AnalisarNome("", 0);
                analisar.ReceberNome();

                double SalBruto = analisar.SalBruto;
                string Nome = analisar.Nome;

                CalculoImpostoRenda calculo = new CalculoImpostoRenda();
                calculo.CalcularImpostoRenda(SalBruto, Nome);

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
//EvolucaoTestes.IRPF