using System;
namespace EvolucaoTestes.IRPF;

public class Contribuinte
{
    public int NumeroContribuintes { get; set; }

    public void ReceberNumeroContribuintes(string contribuinteS)
    {
        if (string.IsNullOrWhiteSpace(contribuinteS)) throw new ArgumentNullException("Contribuintes","É obrigatório um número de contribuintes. Digite novamente.");

        else if (contribuinteS == "0") throw new ArgumentNullException("Contribuintes","É obrigatório um número de contribuintes. Digite novamente.");
       
        else if (int.TryParse(contribuinteS, out int numeroContribuinteInt)) NumeroContribuintes = numeroContribuinteInt;
        
        else throw new ArgumentNullException("Contribuintes","Número de contribuintes inválido. Digite novamente.");
    }

    public void TestarReceberNumeroContribuintes(string? entrada)
{
    if (string.IsNullOrWhiteSpace(entrada))
    {
        throw new ArgumentNullException(nameof(entrada), "Entrada não pode ser nula ou vazia.");
    }

    if (!int.TryParse(entrada, out int numero))
    {
        throw new FormatException("A entrada precisa ser um número válido.");
    }

    if (numero <= 0)
    {
        throw new ArgumentOutOfRangeException(nameof(entrada), "O número deve ser maior que zero.");
    }

    NumeroContribuintes = numero;
}

}