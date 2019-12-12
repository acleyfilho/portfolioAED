using System;

public class ContaPoupanca:Conta{

  private float txRendimento;

  public ContaPoupanca(string tit, string cp, float sald, float txR){
    titular = tit;
    cpf = cp;
    saldo = sald;
    txRendimento = txR;
  }

}
