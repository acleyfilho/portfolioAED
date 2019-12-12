
/*Exercício 1: Modele as seguintes classes com utilização de herança:

ContaPoupança e ContaCorrente
Pessoa Juridica e Pessoa Fisica
Bicicleta e Automóvel
Exercício 2: Após a modelagem e criação das classes em C# crie 2 exceções para as classes criadas.

Exercício 3: Além das exceções criadas, utilize outras exceções comuns como DivideByZero, ArgumentNullException, etc.*/


using System;

class MainClass {
  public static void Main (string[] args) {
    
    ContaCorrente deivisson = new ContaCorrente ("Deivisson Altoé","123.123.123-12",123456f, 5f);

    deivisson.Depositar(100f);
    Console.WriteLine(deivisson.getSaldo());

    deivisson.Sacar(1000f);
    Console.WriteLine(deivisson.getSaldo());




    ContaPoupanca acley = new ContaPoupanca ("Acley Filho","222.222.222-22",123456f,0.1f);

    acley.Depositar(600f);
    Console.WriteLine(acley.getSaldo());

    acley.Sacar(7000f);
    Console.WriteLine(acley.getSaldo());



  }
}