using System;
using System.Security.Cryptography.X509Certificates;
namespace EvolucaoTestes.IRPF;

public class AnalisarNome
{
    public AnalisarNome(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }

    public void ReceberNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            System.Console.WriteLine("Nome inválido. Digite novamente.");
            ReceberNome(Nome);

        }
    }
}
