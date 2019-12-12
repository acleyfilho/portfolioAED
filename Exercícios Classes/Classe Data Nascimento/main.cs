using System;

class MainClass {
  public static void Main (string[] args) {
    Pessoa jao = new Pessoa("João", 19, new Data("01/05/2000"));
    Pessoa ze = new Pessoa("José", 29, new Data("15/05/2000"));  

    Console.WriteLine("Diferença entre Zé e Jão");
    Console.WriteLine(jao.Diferenca(ze));   
  }
}