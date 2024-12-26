using System;
using System.Security.Cryptography.X509Certificates;
namespace EvolucaoTestes.IRPF;

public class CalculoImpostoRenda
{
    public double desconto = 0;
    public double salLiquido = 0;
    private double aliquota = 0;
    private double deducao = 0;

    public void CalcularImpostoRenda(double SalBruto, string Nome)
    {
        if (SalBruto <= 1903.98)
        {
            desconto = 0;
            salLiquido = SalBruto;
        }
        else if (SalBruto <= 2826.65)
        {
            aliquota = 0.075;
            deducao = 142.80;
            desconto = (SalBruto * aliquota) - deducao;
            salLiquido = SalBruto - desconto;
        }
        else if (SalBruto <= 3751.05)
        {
            aliquota = 0.15;
            deducao = 354.80;
            desconto = (SalBruto * aliquota) - deducao;
            salLiquido = SalBruto - desconto;
        }
        else if (SalBruto <= 4664.68)
        {
            aliquota = 0.225;
            deducao = 636.13;
            desconto = (SalBruto * aliquota) - deducao;
            salLiquido = SalBruto - desconto;
        }
        else
        {
            aliquota = 0.275;
            deducao = 869.36;
            desconto = (SalBruto * aliquota) - deducao;
            salLiquido = SalBruto - desconto;
        }
    }

}