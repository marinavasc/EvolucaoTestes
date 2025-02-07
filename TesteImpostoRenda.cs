using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;
namespace EvolucaoTestes.IRPF;

public class TesteImpostoRenda
{
    [Theory]
    [InlineData(1500, 0)]
    [InlineData(2500, 44.70)]
    [InlineData(3500, 170.20)]
    [InlineData(4500, 376.37)]
    [InlineData(5500, 643.14)]
    public void TesteImposto(double salarioBruto, double resultado)
    {
        var impostoRenda = new ImpostoRenda();

        impostoRenda.CalcularImpostoRenda(salarioBruto);

        Assert.Equal(resultado, impostoRenda.Desconto);
    }

    // [Theory]
    // [InlineData(0.0, 0)]
    // [InlineData(null, 0)]
    // public void TesteImpostoRendaInvalido(double? salarioBruto, double impostoEsperado)
    // {
    //     var impostoRenda2 = new ImpostoRenda();

    //     impostoRenda2.CalcularImpostoRenda(salarioBruto ?? 0);

    //     Assert.Equal(impostoEsperado, impostoRenda2.Desconto);
    // }

}