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
        var contribuinte = new Contribuinte();

        contribuinte.ReceberNumeroContribuintes(entradaValida);

        Assert.Equal(numeroEsperado, contribuinte.NumeroContribuintes);
    }

    [Theory]
    [InlineData(null, "É obrigatório um número de contribuintes. Digite novamente.")]
    [InlineData("", "É obrigatório um número de contribuintes. Digite novamente.")]
    [InlineData(" ", "É obrigatório um número de contribuintes. Digite novamente.")]
    [InlineData("0", "É obrigatório um número de contribuintes. Digite novamente.")]
    public void TesteReceberNumeroContribuintesInvalido(string entrada, string mensagemEsperada)
    {
        var contribuinte = new Contribuinte();

        var ex = Assert.Throws<ArgumentNullException>(() => contribuinte.ReceberNumeroContribuintes(entrada));

        Assert.Contains(mensagemEsperada, ex.Message);
    }

}
