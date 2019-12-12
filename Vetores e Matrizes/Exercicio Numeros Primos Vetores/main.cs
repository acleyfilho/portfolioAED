/*Faça um programa em C# que imprima todos
os números primos de um vetor de inteiros.*/

using System;

class MainClass {
  public static bool Primo(int numero){
    int qtdDivisores = 0;

    for (int i = numero; i > 0; i--){
      if (numero % i == 0)
        qtdDivisores++;
    }

    return qtdDivisores > 2 ? false: true;
  }



  public static void Main (string[] args) {

    int[] vetor = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};

    for (int i = 0; i < vetor.Length; i++){
      if (Primo(vetor[i]))
        Console.WriteLine("O elemento primo de índice {0} é primo e é: {1}",i,vetor[i]);
    }

  }
}