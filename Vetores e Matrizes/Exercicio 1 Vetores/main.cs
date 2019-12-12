using System;

class MainClass {
  public static void Main (string[] args) {
    
    /*Crie um programa em C# que realize o preenchimento de um vetor com 10 números inteiros a partir da entrada padrão (teclado) e, em seguida, imprima esses dados na tela para o usuário.*/

    int[] numeros = new int[10];

    for (int i = 0; i < numeros.Length; i++){
      Console.WriteLine("Digite um número: ");
      numeros[i] = int.Parse(Console.ReadLine());
    }
    
    
    for (int i = 0; i < numeros.Length; i++){
      Console.WriteLine("Os números foram: {0}", numeros[i]);
    }




  }
}