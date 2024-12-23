using System;
using System.Security.Cryptography.X509Certificates;
namespace EvolucaoTestes.IRPF;

public class CalculoImpostoRenda
{
    public double Desconto { get; set; }
    public double SalLiquido { get; set; }
    public double Aliquota { get; set; }
    public double Deducao { get; set; }

    public void CalcularImpostoRenda(double SalBruto, string Nome)
    {
        if (SalBruto <= 1903.98)
        {
            Desconto = 0;
            SalLiquido = SalBruto;
        }
        else if (SalBruto <= 2826.65)
        {
            Aliquota = 0.075;
            Deducao = 142.80;
            Desconto = (SalBruto * Aliquota) - Deducao;
            SalLiquido = SalBruto - Desconto;
        }
        else if (SalBruto <= 3751.05)
        {
            Aliquota = 0.15;
            Deducao = 354.80;
            Desconto = (SalBruto * Aliquota) - Deducao;
            SalLiquido = SalBruto - Desconto;
        }
        else if (SalBruto <= 4664.68)
        {
            Aliquota = 0.225;
            Deducao = 636.13;
            Desconto = (SalBruto * Aliquota) - Deducao;
            SalLiquido = SalBruto - Desconto;
        }
        else
        {
            Aliquota = 0.275;
            Deducao = 869.36;
            Desconto = (SalBruto * Aliquota) - Deducao;
            SalLiquido = SalBruto - Desconto;
        }

        Console.WriteLine("\nResultados do Cálculo:");
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"Salário bruto: {SalBruto.ToString("C2")}");
        Console.WriteLine($"Imposto: {Desconto.ToString("C2")}");
        Console.WriteLine($"Salário líquido: {SalLiquido.ToString("C2")}\n");

    }

}