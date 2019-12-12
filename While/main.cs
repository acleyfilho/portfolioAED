using System;

class MainClass {
  public static void Main (string[] args) {
    
    char caractere = ' ';
    bool ehVogal = false;

    

    while(ehVogal == false){
      Console.WriteLine("Digite uma letra: ");
      caractere = char.Parse(Console.ReadLine());
      
      switch (char.ToUpper(caractere)){
        case 'A': case 'E': case 'I': case 'O': case 'U':
          ehVogal = true;
          break;
        default:
          ehVogal = false;
          break;
      }
      

    }
    Console.WriteLine("A vogal encontrada foi: {0}",caractere);
  }
}