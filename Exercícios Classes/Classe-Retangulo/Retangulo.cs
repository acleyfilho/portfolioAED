class Retangulo{
  private float ladoA;

  private float ladoB;


  public float getLadoA(){
    return ladoA;
  }

  public float getLadoB(){
    return ladoB;
  }

  public string mostrarLados(){
    return "Lado A: " + ladoA + "\r\n" + "Lado B: " + ladoB;
  }

  public Retangulo(float a, float b){
    this.ladoA = a;

    this.ladoB = b;
  }

  public void mudarLados(float nladoA, float nladoB){
    ladoA = nladoA;
    ladoB = nladoB;
  }

  public float calcArea(){
    return ladoA*ladoB;
  }

  public float calcPerim(){
    return 2*ladoA + 2*ladoB;
  }
  
}