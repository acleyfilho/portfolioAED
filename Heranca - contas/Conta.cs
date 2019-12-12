using System;

public class Conta{

  protected string titular;

  protected string cpf;

  protected float saldo;

  public float getSaldo(){
    return saldo;
  }


 /* public Conta(string tit, string cp, float sald){
    titular = tit;
    cpf = cp;
    saldo = sald;
  }*/
  

  public void Sacar(float valorSacado){
    try{
      if (saldo - valorSacado >= 0){
      saldo -= valorSacado;
      Console.WriteLine("Saque efetuado!");
      }
      else{
        Console.WriteLine("Seu saldo não é suficiente!");
      }
    }
    catch(DivideByZeroException x){
      Console.WriteLine("Impossível dividir por zero!");
    }

    catch(ArgumentNullException x){
      Console.WriteLine("Valor não informado!");
    }
    
    
  }


  public void Depositar(float valorDepositado){
    try{
      if (valorDepositado >= 0){
        saldo += valorDepositado;
        Console.WriteLine("Depósito efetuado!");
      }
      
      else{
        Console.WriteLine("Valor inválido!");
      }
    }
    catch(DivideByZeroException x){
      Console.WriteLine("Impossível dividir por zero!");
    }

    catch(ArgumentNullException x){
      Console.WriteLine("Valor não informado!");
    }
    
  }
}
