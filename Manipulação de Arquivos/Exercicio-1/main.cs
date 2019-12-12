using System;
using System.IO;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
    
    /*Fazer um programa em C# para realizar a leitura de 10 números
inteiros de um arquivo texto e imprimir na tela a média dos 10
números lidos.*/

  FileStream meuArq = new FileStream ("dados.txt", FileMode.Open, FileAccess.Read);

  StreamReader numeros = new StreamReader(meuArq, Encoding.UTF8);

  int soma = 0;
  while(!numeros.EndOfStream){
    int num = int.Parse(numeros.ReadLine());
    soma = soma + num;
    Console.WriteLine(num);
  }

  Console.WriteLine(soma);

  numeros.Close();
  meuArq.Close();

  }
}