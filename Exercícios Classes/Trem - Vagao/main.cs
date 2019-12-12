using System;

class MainClass{

  public static void Main (string[] args){


    Vagao primeiro = new Vagao(50,"Brita");
    Vagao segundo = new Vagao(30,"Carvao");
    Vagao terceiro = new Vagao(20,"Ouro");
  
    Trem locomotiva = new Trem(100,"Cargueiro",primeiro, segundo, terceiro,40);

    
    Console.WriteLine("{0}, Carga total dos vagoes: {1}",locomotiva.cargaRestante(),locomotiva.cargaTotal());//usando o objeto locomotiva como referencia eu chamei o metodos cargaRestante e cargaTotal 
    
   
  }
}