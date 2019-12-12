using System;

public class ContaCorrente:Conta{

  private float txManutencao;

  public ContaCorrente(string tit, string cp, float sald, float txM){
    titular = tit;
    cpf = cp;
    saldo = sald;
    txManutencao = txM;
  }

  

}
