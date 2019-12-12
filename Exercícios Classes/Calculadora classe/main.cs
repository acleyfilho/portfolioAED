using System;

class MainClass {
  public static void Main (string[] args) {
     Console.WriteLine("Informe um número:"); 
     int num1 = int.Parse(Console.ReadLine());
     Console.WriteLine("Informe outro número:"); 
     int num2 = int.Parse(Console.ReadLine());

     int soma = CalculadoraInt.Soma(num1, num2);
     Console.WriteLine("Soma: {0}+{1}={2}", num1, num2, soma);

     soma = CalculadoraInt.Soma(23, 7);
     Console.WriteLine("Soma: {0}+{1}={2}", 23, 7, soma);

     CalculadoraInt cassio = new CalculadoraInt(num1, num2);
     cassio.setOperando1(num1+2);
     cassio.setOperando2(num2+10);

     soma = cassio.Soma();
     Console.WriteLine("Soma: {0}+{1}={2}", cassio.getOperando1(), cassio.getOperando2(), soma);

     Console.WriteLine("Maior: {0}", cassio.Maior());

  }
}