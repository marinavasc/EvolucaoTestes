using System;
using System.Security.Cryptography.X509Certificates;
namespace EvolucaoTestes.IRPF;

public class AnalisarNome
{
    public AnalisarNome(string nome, double salBruto)
    {
        Nome = nome;
        SalBruto = salBruto;
    }

    public double SalBruto { get; set; }
    public string Nome { get; set; }

    public void ReceberNome()
    {
        Console.Write("\nQual seu nome? ");

            Nome = Console.ReadLine()!;

            if (string.IsNullOrWhiteSpace(Nome))
            {
               System.Console.WriteLine("\nDigite um nome válido. \nDigite qualquer tecla para voltar.");
                Console.ReadKey();
                ReceberNome();
            }
            else
            {
                 double salarioTemporario = SalBruto;
                AnalisarSalario.ReceberSalario(ref salarioTemporario);
                SalBruto = salarioTemporario; 
            }
        }
}