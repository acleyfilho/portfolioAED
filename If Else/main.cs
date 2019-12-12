/*
Melhore o código do programa acima permitindo que o
usuário participe do “jogo” de adivinhação apenas se for
maior de idade e se for estudante e se for do curso de
análise e desenvolvimento de sistemas.
– Use if’s aninhados e switch’s para resolver o problema.
*/
using System;

class MainClass {
  public static void Main (string[] args) {

    string ocupacao = "";
    string curso = "";
    int idade = 0;
    Console.WriteLine("Qual é a sua idade?  ");
    idade = int.Parse(Console.ReadLine());

    if (idade >= 18){
      Console.WriteLine("Qual é a sua ocupação?  ");
      ocupacao = Console.ReadLine();

      if (ocupacao == "estudante" || ocupacao == "Estudante"){
        Console.WriteLine("Qual é o seu curso?  ");
        curso = Console.ReadLine();

        if (curso =="Sistemas" || curso == "sistemas"){
          Console.WriteLine("Muito bem, você é um participante válido! \n Digite a frase premiada: ");
          string frase = Console.ReadLine();

          switch (frase){
            case "Ganhei":
              Console.WriteLine("Parabéns, você ganhou o prêmio de R$1.000.000,00");
              break;
            case "Perdi":
              Console.WriteLine("Parabéns, você ganhou o prêmio de R$1.000.000,00");
              break;
            case "Sou vitorioso":
              Console.WriteLine("Parabéns, você ganhou o prêmio de R$1.000.000,00");
              break;
            case "Vencedor":
              Console.WriteLine("Parabéns, você ganhou o prêmio de R$1.000.000,00");
              break;
            case "Sucesso":
              Console.WriteLine("Parabéns, você ganhou o prêmio de R$1.000.000,00");
              break;
            default:
              Console.WriteLine("Sinto muito, não foi dessa vez :(");
              break;
          }
        }
      }
    }

    

    



  }
}