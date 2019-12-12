/*using System;

class Robo {

//Uma classe é composta por atributos (características ou propriedades de um objeto!!!)
//As classes poderm ser: públicas (pode ser acessada por um método), privadas(não podem ser acessadas), protected
//Ao adicionar o static (eu estou definindo que os métodos estáticos não recebem os dados dos objetos, mas ela pode acessar atributos definidos com estáticos(ou seja, atributos que são compartilhados por todos os objetos))
public string Nome;

//Atributo não estático. Cada robo tem a sua chave de segurança
private int securityKey;

//Atributo estático.
//Este atributo pertence à classe, mas é compartilhado com os objetos
public static string codigo;


//métodos construtores
//Método não estático: cada objeto tem o seu próprio método
public void mensagemCodigo(){
  Console.WriteLine("[{0}]:{1}",Nome,codigo );

}


//Construtor da classe
public Robo(string nom){
  Nome = nom;
}


//Método estático
//Só pode ser acessado diretamente pela classe Robo.metodoestatico()
public static void NovoCodigo(string cod){
  codigo = cod;
}




}



class MainClass {
  public static void Main (string[] args){
    Robo walle = new Robo("Walle");
    Robo eva = new Robo("Eva");

    Robo.NovoCodigo("A mensagem é: Todos os humanos serão exterminados em 50 meses, se preparem!");

    eva.mensagemCodigo();
    walle.mensagemCodigo();

  }
}
*/

using System;

class Zumbis {

//Definição dos atributos pertencentes à classe Zumbis
  private static string TomdePele;

  public string Identificacao;


//Definição dos métodos 
//Construtor da classe Zumbis
public Zumbis(string Id){
  Identificacao = Id;
}


//Método não estático. Cadas zumbi possui a sua própria Identificação

public void Caracteristica(){
  Console.WriteLine("Id - {0} : O tom de pele atual é {1} ",Identificacao,TomdePele);

}

public static void NovoTomdePele(string Tom){
  TomdePele = Tom;
}

}


class MainClass{
  public static void Main (string[] args){
    Zumbis crazy = new Zumbis("aeprgn[aweroj3q4-j");
    Zumbis Flurck = new Zumbis("j23t=jgiawerhjws\aj");
    
    Zumbis.NovoTomdePele("Azul");

    crazy.TomdePele();
    Flurck.TomdePele();
  }
}


