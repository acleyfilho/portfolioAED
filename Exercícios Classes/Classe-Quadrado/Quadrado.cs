class Quadrado{
  private float lado;

  public float getLado(){
    return lado;
  }

  public Quadrado(float quad){
   (this).lado = quad;
  }


  public void mudarLado(float novolado){
    (this).lado = novolado;
  }


  public float areaLado(){
    return lado*lado;
  }

}