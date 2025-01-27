using System;
using Xunit;
namespace EvolucaoTestes.IRPF;

public class TesteReceberNomeContribuinte
{

    [Fact]
    public void TesteContribuinteNulo()
    {
        // Arrange
        var contribuinte = new Contribuinte();
        string? entradaNula = null;

        // Act e Assert
        Assert.Throws<ArgumentNullException>(() => contribuinte.TestarReceberNumeroContribuintes(entradaNula!));
    }

    [Fact]
    public void TesteNumeroContribuintesValidos()
    { // Arrange
        var contribuinte = new Contribuinte();
        string entradaValida = "5";

        // Act
        contribuinte.TestarReceberNumeroContribuintes(entradaValida);

        // Assert
        Assert.Equal(5, contribuinte.NumeroContribuintes);
    }

    [Fact]
    public void TesteNumeroContribuintesInvalidos()
    {
        // Arrange
        var contribuinte = new Contribuinte();
        string entradaInvalida = "abc";

        // Act e Assert
        Assert.Throws<FormatException>(() => contribuinte.TestarReceberNumeroContribuintes(entradaInvalida));
    }
}
