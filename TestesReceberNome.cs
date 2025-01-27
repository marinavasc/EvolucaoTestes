using System;
using Xunit;
namespace EvolucaoTestes.IRPF;

public class TesteReceberNome
{
    [Fact]
    public void TesteReceberNomeContribuinteVazio()
    {
        // Arrange
        string nomeVazio = "";

        // Act e Assert
        Assert.Throws<ArgumentNullException>(() => new Pessoa(nomeVazio));
    }

    [Fact]
    public void TesteReceberNomeContribuinteNulo()
    {
        // Arrange
        string? nomeNulo = null;

        // Act e Assert
        Assert.Throws<ArgumentNullException>(() => new Pessoa(nomeNulo!));
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
}