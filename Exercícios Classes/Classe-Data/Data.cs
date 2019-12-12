class Data{
  private int dia, mes, ano;

  public int getDia(){
    return dia;
  }
  public int getMes(){
    return mes;
  }
  public int getAno(){
    return ano;
  }
  public void setDia(int d){
    dia = d;
  }

  public void setMes(int m){
    mes = m;
  } 

  public void setAno(int a){
    ano = a;
  }

  public void setData(string str_data){
    string[] dat = str_data.Split("/");
    dia = int.Parse(dat[0]);
    mes = int.Parse(dat[1]);
    ano = int.Parse(dat[2]);    
  } 

  public Data(){
    dia=1;
    mes=1;
    ano=2000;
  }

  public Data(int d, int m, int a){
    dia = d;
    mes = m;
    ano = a;
  }

  public Data(string str_data){
    setData(str_data);
  }

  public override string ToString(){
    return string.Format("{0}/{1}/{2}",dia, mes, ano);
  } 

  public string NomeMes(){
    string[] meses = new string[] {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};

    return meses[mes-1];
  }

}