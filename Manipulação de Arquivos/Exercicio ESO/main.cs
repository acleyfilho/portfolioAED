using System;
using System.IO;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
    
    FileStream meuArquivo = new FileStream("numeros.txt", FileMode.Open, FileAccess.Read);

    StreamReader leitura = new StreamReader(meuArquivo, Encoding.UTF8);

    int num1 = int.Parse(leitura.ReadLine());
    int num2 = int.Parse(leitura.ReadLine());

    Console.WriteLine("{0} + {1} = {2}", num1,num2,num1+num2);


  }
}
