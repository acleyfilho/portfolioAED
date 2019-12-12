class Pessoa{
  private string nome;
  private int idade;
  private Data dataNascimento;

  public Data getDataNascimento(){
    return dataNascimento;
  }

  public void setDataNascimento(Data dt){
    dataNascimento = dt;
  }

  public string getNome(){
    return nome;
  }

  public int getIdade(){
    return idade;
  }

  //Acesso  TipoRetorno  Nome(  Parametros )
  public string maisVelho(int id, string n){
    if(idade > id)
      return nome;
    else
      return n;
  }
  //Acesso  TipoRetorno  Nome(  Parametros )
  public Pessoa maisVelho(Pessoa outra){
    if(idade > outra.idade)
      return this;
    
    return outra;
  }

  //Construtor da classe:
  public Pessoa(){
    nome = "Sem nome ainda!";
    idade = 0;
    dataNascimento = new Data("01/01/2000");
  }
  public Pessoa(string n, int i){
    nome = n;
    idade = i;
    dataNascimento = new Data(01, 01, 2000);
  }

  public Pessoa(string n, int i, Data dt){
    nome = n;
    idade = i;
    dataNascimento = dt;   
  }

  public int Diferenca(Pessoa outra_pes){
    return this.dataNascimento.Diferenca(outra_pes.dataNascimento);
  }

}