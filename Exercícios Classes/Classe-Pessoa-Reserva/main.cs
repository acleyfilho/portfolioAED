using System;

class MainClass {
  public static void Main (string[] args) {
    
    /* Crie uma classe para representar uma Data que possua:

    pelo menos 2 construtores

    Os métodos get e set

    Implemente o método público NomeMes() que retorna o nome do mês atualmente configurado em um objeto da classe Data.

    Implemente o método Bisexto() que retorna verdadeiro se o ano atual for bissexto, e retorna false caso contrário.

    Implemente o método Incrementa(int dias) da classe Data. Esse método adiciona à data atual o número de dias informado com
    parâmetro.

    Implemente o método Diferença que retorna o número de dias entre duas datas (a atual e uma outra informada como parâmetro)*/


    Pessoa p1 = new Pessoa("Jack",25);
    Pessoa p2 = new Pessoa("Joana",78);

    Console.WriteLine("O mais velho é: {0}", p1.maisVelho(p2.getIdade(),p2.getNome()));

  }
}