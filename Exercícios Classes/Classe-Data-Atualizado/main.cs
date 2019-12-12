using System;

class MainClass {
  public static void Main (string[] args) {
    Data my_date = new Data("12/09/2019");

    Console.WriteLine(my_date);

    Console.WriteLine(my_date.NomeMes());

    Console.WriteLine(my_date.Bissexto());
    my_date.setData("12/09/2000");
    Console.WriteLine(my_date);
    Console.WriteLine(my_date.Bissexto());
    my_date.Incrementa(10);
    Console.WriteLine(my_date);
  }
}