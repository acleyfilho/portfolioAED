using System;

class MainClass {
  public static void Main (string[] args) {
    

    Retangulo grande = new Retangulo(400,900);

  Console.WriteLine(grande.mostrarLados());

  grande.mudarLados(100,100);

  Console.WriteLine("Processamento...");

  Console.WriteLine(grande.mostrarLados());

  Console.WriteLine(grande.calcArea());

  Console.WriteLine(grande.calcPerim());

  }
}