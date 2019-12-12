using System;

class MainClass {
  public static void Main (string[] args) {
    
  Quadrado medio = new Quadrado(19);

  Console.WriteLine(medio.getLado());

  medio.mudarLado(50);

  medio.areaLado();

  Console.WriteLine(medio.areaLado());
    
  }
}