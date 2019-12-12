class Pessoa{
  private string nome;

  private int idade;

  public string getNome{
    return nome;
  }

  public int getIdade{
    return idade;
  }

    //Acesso  TipoRetorno  Nome(  Parametros )
  public string maisVelho(int id, string n){
    if (idade > id){
      return nome;
    else
      return n;
    }
  }

  //This é referência ao próprio objeto que chamou o método! O this é usado para referenciar mais de um objeto...
  public Pessoa maiorIMC()

  //Construtor de classe:
  public Pessoa(){
    nome = "sem nome ainda!";
    idade = 0;
  }

  public Pessoa(string id, int n)
    nome = n;
    idade = id;
}