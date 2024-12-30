using System;
using System.Security.Cryptography.X509Certificates;
namespace EvolucaoTestes.IRPF;

public class CalculoImpostoRenda
{
    public double Desconto { get; private set; }
    public double SalLiquido { get; private set; }
    private double aliquota = 0;
    private double deducao = 0;

    public void CalcularImpostoRenda(double SalBruto)
    {
        if (SalBruto <= 1903.98)
        {
            Desconto = 0;
            SalLiquido = SalBruto;
        }
        else if (SalBruto <= 2826.65)
        {
            aliquota = 0.075;
            deducao = 142.80;
            Desconto = (SalBruto * aliquota) - deducao;
            SalLiquido = SalBruto - Desconto;
        }
        else if (SalBruto <= 3751.05)
        {
            aliquota = 0.15;
            deducao = 354.80;
            Desconto = (SalBruto * aliquota) - deducao;
            SalLiquido = SalBruto - Desconto;
        }
        else if (SalBruto <= 4664.68)
        {
            aliquota = 0.225;
            deducao = 636.13;
            Desconto = (SalBruto * aliquota) - deducao;
            SalLiquido = SalBruto - Desconto;
        }
        else
        {
            aliquota = 0.275;
            deducao = 869.36;
            Desconto = (SalBruto * aliquota) - deducao;
            SalLiquido = SalBruto - Desconto;
        }
    }

}