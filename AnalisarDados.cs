using System;
using System.Security.Cryptography.X509Certificates;
namespace EvolucaoTestes.IRPF;

public class AnalisarNome
{
    // public AnalisarNome(string nome)
    // {
    //     Nome = nome;
    // }

    // public double SalBruto { get; set; }
    // public string Nome { get; set; }

    // public void ReceberNome()
    // {
    //     if (string.IsNullOrWhiteSpace(Nome))
    //     {
    //         Console.ReadKey();
    //         ReceberNome();
    //     }
    //     else
    //     {
            
    //     }
    // }
    public static bool ValidarNome(string nome)
    {
        return !string.IsNullOrWhiteSpace(nome);
    }
}
