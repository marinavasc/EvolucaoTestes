using System;
using Xunit;
namespace EvolucaoTestes.IRPF;

public class TesteReceberNome
{
    [Fact]
    public void TesteReceberNomeContribuinteVazio()
    {
        // Arrange
        var nome = new Pessoa("");

        // Act
        var resultado = nome.Nome;

        // Assert
        Assert.Equal("", resultado);
    }

    [Fact]
    public void TesteReceberNomeContribuinteValido()
    {
        // Arrange
        var nome = new Pessoa("João Silva");

        // Act
        var resultado = nome.Nome;

        // Assert
        Assert.Equal("João Silva", resultado);
    }

    [Fact]
    public void TesteReceberNomeContribuinteNulo()
    {
        // Arrange
        var nome = new Pessoa(null!);

        // Act & Assert
        Assert.Null(nome.Nome);
    }
}