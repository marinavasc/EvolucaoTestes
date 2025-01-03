using System;
namespace EvolucaoTestes.IRPF;

public class Contribuinte
{
    public string NumeroContribuintes { get; set; }

    public Contribuinte(string numeroContribuintes)
    { 
        NumeroContribuintes = numeroContribuintes;
    }

    public void ReceberNumeroContribuintes(string numeroContribuintes)
    {
        if (!int.TryParse(NumeroContribuintes, out int numeroContribuinteInt)) throw new ArgumentNullException("Número de contribuintes", "Número de contribuintes obrigatório. Digite novamente.");
    }

}