using System;

class MainClass {
  public static void Main (string[] args) {
    
    Bola azul = new Bola("azul",3.5f,"diamante");
    azul.trocarCor("verde");
    //Console.WriteLine(azul.getCor());

    azul.mostrarCor();

    
    
  }
}