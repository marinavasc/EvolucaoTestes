using System;
using System.Security.Cryptography.X509Certificates;
namespace EvolucaoTestes.IRPF;

public class AnalisarSalario
{

    public static void ReceberSalario(ref double SalBruto)
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
            ReceberSalario(ref SalBruto);
        }
    }
}