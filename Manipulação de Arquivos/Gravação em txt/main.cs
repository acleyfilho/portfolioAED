using System;
using System.IO;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
    
    FileStream meuArq = new FileStream ("dados.txt", FileMode.Open, FileAccess.Write);

    StreamWriter insertDados = new StreamWriter(meuArq, Encoding.UTF8);

    string dados = string.Empty;

      while(dados != "sair"){
        dados = Console.ReadLine();

        insertDados.WriteLine(dados);


      }

      insertDados.Close();
      meuArq.Close();
  }
}