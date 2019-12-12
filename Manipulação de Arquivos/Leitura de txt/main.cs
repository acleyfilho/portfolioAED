using System;
using System.IO;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
    FileStream meuArq = new FileStream ("dados.txt", FileMode.Open, FileAccess.Read);

    StreamReader sr = new StreamReader (meuArq, Encoding.UTF8);

    while(!sr.EndOfStream){

      string str = sr.ReadLine();
      Console.WriteLine(str);
    }

    sr.Close();
    meuArq.Close();
  }
}