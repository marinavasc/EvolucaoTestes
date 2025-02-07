using System;
namespace EvolucaoTestes.IRPF;

public class Pessoa
{
     public Pessoa(string nome)
 {
     Nome = nome;
 }

 public string Nome { get; set; }

 public void ReceberNome(string nome)
 {
     if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentNullException("Nome", "Nome inválido. Digite novamente.");
 }
 
}
