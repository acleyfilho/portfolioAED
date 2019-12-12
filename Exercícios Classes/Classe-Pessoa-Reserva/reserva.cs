using System;

class MainClass {
  public static void Main (string[] args) {
  Pessoa p1 = new Pessoa("Joao", 133);
  Pessoa p2 = new Pessoa("Maria", 54);

  Console.WriteLine("Mais Velho V1: {0}", p1.maisVelho(p2.getIdade(), p2.getNome()));

  Pessoa resultado = p1.maisVelho(p2);
  Console.WriteLine("Mais Velho V2: {0}", resultado.getNome() );

  }
}