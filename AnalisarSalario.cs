using System;
using System.Security.Cryptography.X509Certificates;
namespace EvolucaoTestes.IRPF;

public class AnalisarSalario
{
    public double SalBruto { get; set; }


    public void ReceberSalario(double SalBruto)
    {
        if (SalBruto > 1412)
        {
            System.Console.WriteLine("Nome inválido. Digite novamente.");
            ReceberSalario(SalBruto);
        }

    }

}
