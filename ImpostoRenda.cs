using System;
namespace EvolucaoTestes.IRPF;

public class ImpostoRenda
{
    public double Desconto { get; set; }
    public double SalarioLiquido { get; set; }
    private double aliquota = 0;
    private double deducao = 0;

    public void CalcularImpostoRenda(double salarioBruto)
    {
        if (salarioBruto <= 1903.98)
        {
            Desconto = 0;
            SalarioLiquido = salarioBruto;
        }
        else if (salarioBruto <= 2826.65)
        {
            aliquota = 0.075;
            deducao = 142.80;
            Desconto = (salarioBruto * aliquota) - deducao;
            SalarioLiquido = salarioBruto - Desconto;
        }
        else if (salarioBruto <= 3751.05)
        {
            aliquota = 0.15;
            deducao = 354.80;
            Desconto = (salarioBruto * aliquota) - deducao;
            SalarioLiquido = salarioBruto - Desconto;
        }
        else if (salarioBruto <= 4664.68)
        {
            aliquota = 0.225;
            deducao = 636.13;
            Desconto = (salarioBruto * aliquota) - deducao;
            SalarioLiquido = salarioBruto - Desconto;
        }
        else
        {
            aliquota = 0.275;
            deducao = 869.36;
            Desconto = (salarioBruto * aliquota) - deducao;
            SalarioLiquido = salarioBruto - Desconto;
        }
    }

}