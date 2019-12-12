using System;

class MainClass {
  public static void Main (string[] args) {
    Caneta joyce = new Caneta("Azul");
   
    Caneta pamela = new Caneta(Console.ReadLine(), 
                               Console.ReadLine(), 
                               float.Parse(Console.ReadLine()));

    Console.WriteLine("Informe a nova cor para a Joyce");
    string novaCor = Console.ReadLine();
    joyce.setCor(novaCor);

    Console.WriteLine(joyce.ResumoDados());
    Console.WriteLine(pamela.ResumoDados());
  }
}