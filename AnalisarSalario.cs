using System;
using System.Security.Cryptography.X509Certificates;
namespace EvolucaoTestes.IRPF;

public class AnalisarSalario
{
    public double SalBruto { get; set; }

    public void ReceberSalario(double SalBruto)
    {
        try
        {
            
        }
        catch (Exception e)
        {
            Console.ReadKey();
            ReceberSalario(SalBruto);
        }
    }
}
