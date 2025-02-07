using System;
using Xunit;
namespace EvolucaoTestes.IRPF;

public class TesteReceberNome
{
    [Theory]
    [InlineData("João")]
    [InlineData("Maria")]
    [InlineData("Carlos")]
    [InlineData("João Pedro")]
    public void TesteReceberNomeValido(string nome)
    {
        // Arrange
        var pessoa = new Pessoa("nome padrão");

        // Act
        pessoa.ReceberNome(nome);

        // Assert
        Assert.Equal(nome, pessoa.Nome);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    public void TesteReceberNomeInvalido(string nomeInvalido)
    {
        // Arrange
        var pessoa = new Pessoa("Nome Padrão");

        // Act & Assert
        var ex = Assert.Throws<ArgumentNullException>(() => pessoa.ReceberNome(nomeInvalido));
        Assert.Contains("Nome inválido", ex.Message);
    }
}