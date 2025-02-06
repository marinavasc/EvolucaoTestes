using System;
using Xunit;
namespace EvolucaoTestes.IRPF;

public class TesteReceberContribuinte
{
        [Theory]
    [InlineData("5", 5)]
    [InlineData("10", 10)]
    [InlineData("2", 2)]
    public void TesteNumeroContribuintesValidos(string entradaValida, int numeroEsperado)
    {
        // Arrange
        var contribuinte = new Contribuinte();

        // Act
        contribuinte.ReceberNumeroContribuintes(entradaValida);

        // Assert
        Assert.Equal(numeroEsperado, contribuinte.NumeroContribuintes);
    }
}
