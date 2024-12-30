using System;
using System.Security.Cryptography.X509Certificates;
namespace EvolucaoTestes.IRPF;

public class AnalisarSalario
{
    // public double SalBruto { get; set; }

    // public void ReceberSalario(double SalBruto)
    // {
    //     try
    //     {
    //         if (double.TryParse(Console.ReadLine(), out double salBruto))
    //         {
    //             SalBruto = salBruto;
    //         }
    //         else
    //         {
    //             throw new Exception();
    //         }
    //     }
    //     catch (Exception e)
    //     {
    //         Console.ReadKey();
    //         ReceberSalario(SalBruto);
    //     }
    // }
    public static bool ValidarSalario(string? input, out double salarioBruto)
    {
        if (double.TryParse(input, out salarioBruto) && salarioBruto > 1412)
        {
            return true;
        }
        salarioBruto = 0;
        return false;
    }
}
