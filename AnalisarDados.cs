using System;
using System.Security.Cryptography.X509Certificates;
namespace EvolucaoTestes.IRPF;

public class AnalisarDados
{
    public AnalisarDados(string nome, double salBruto)
    {
        Nome = nome;
        SalBruto = salBruto;
    }

    public string Nome { get; set; }
    public double SalBruto { get; set; }

    public void ReceberDados()
    {
        Console.Write("\nQual seu nome? ");
        try
        {
            Nome = Console.ReadLine()!;

            if (System.Text.RegularExpressions.Regex.IsMatch(Nome, @"^[a-zA-Z]+$"))
            {
                Console.Write("E qual seu salário bruto? ");
                string salBrutoString = Console.ReadLine()!;

                try
                {
                    SalBruto = double.Parse(salBrutoString);
                    if (SalBruto <= 0)
                    {
                        throw new Exception("Digite um valor válido.");
                    }
                }
                catch
                {
                    Console.WriteLine("\nValor inválido. ");
                    Console.WriteLine("Digite qualquer tecla para voltar.");
                    Console.ReadKey();
                    ReceberDados();
                }
            }
            else if (Nome == "")
            {
                System.Console.WriteLine("\nDigite um nome válido. \nDigite qualquer tecla para voltar.");
                Console.ReadKey();
                ReceberDados();
            }
            else
            {
                System.Console.WriteLine("\nDigite um nome válido. \nDigite qualquer tecla para voltar.");
                Console.ReadKey();
                ReceberDados();
            }

        }
        catch
        {
            System.Console.WriteLine("\nDigite um nome válido. \nDigite qualquer tecla para voltar.");
            Console.ReadKey();
            ReceberDados();
        }
    }
}
