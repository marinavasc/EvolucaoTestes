using System;
using System.Security.Cryptography.X509Certificates;
namespace EvolucaoTestes.IRPF;

public class AnalisarSalario
{

    public static void ReceberSalario(ref double SalBruto)
    {
        Console.Write("E qual seu salário bruto? ");
        string salBrutoString = Console.ReadLine()!;

            if (double.TryParse(salBrutoString, out double salBruto)) SalBruto = salBruto;
            
            else if (SalBruto < 1412) Console.WriteLine("Valor mínimo igual a R$1.412,00.");
            
            else Console.WriteLine("Valor inválido.");
    }
}
