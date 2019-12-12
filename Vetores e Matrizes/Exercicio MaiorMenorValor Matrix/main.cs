/************
Exercício 5: Crie um programa em C# que realize o preenchimento de uma matriz 4x3 com números inteiros e, em seguida, após a leitura completa, imprima para o usuário o maior e o menor valor.
***/
using System;

class MainClass {
  public static void Main (string[] args) {
    int[,] dados = new int[4,3];

    //Leitura dos Dados:
    for(int i=0; i<4; i++){
      Console.WriteLine("Informe os números da {0}ª linha :", i+1);
      for(int j=0; j<3; j++){
         dados[i,j] = int.Parse(Console.ReadLine());
      }
    }

    //Processamento dos dados:
    int maior=dados[0,0], menor=dados[0,0];
    for(int i=0; i<4; i++){
      for(int j=0; j<3; j++){
        if(dados[i,j] > maior)
          maior = dados[i,j];
        
        if(dados[i,j] < menor)
          menor = dados[i,j];
      }
    }    
    Console.WriteLine("Maior: {0} - Menor: {1}", maior, menor);
  }
}