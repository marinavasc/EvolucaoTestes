using System;
using System.Security.Cryptography.X509Certificates;
namespace EvolucaoTestes.IRPF;

public class AnalisarSalario
{

    public static void ReceberSalario(ref double SalBruto)
    {
        Console.Write("E qual seu salário bruto? ");
        string salBrutoString = Console.ReadLine()!;

        if (double.TryParse(salBrutoString, out double salBruto))
        {
            if (salBruto < 1412)
            {
                Console.WriteLine("O valor mínimo permitido é R$1.412,00.");
                ReceberSalario(ref SalBruto);
            }

            else SalBruto = salBruto;
        }
        else
        {
            Console.WriteLine("Valor inválido. Insira um número válido.");
            ReceberSalario(ref SalBruto);
        }
    }

}
