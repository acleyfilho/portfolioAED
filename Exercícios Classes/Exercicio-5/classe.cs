class Bola{
  private string cor;

  private float circunf;

  private string material;

  public string getCor(){
    return cor;
  }



  public float getCircunf(){
    return circunf;
  }


  public string getMaterial(){
    return material;
  }



  public void trocarCor(string novacor){
    (this).cor = novacor;
  }

  public string mostrarCor(){
    return cor;
  }



  public Bola(string c, float cir, string mat){
    this.cor = c;
    this.circunf = cir;
    this.material = mat;
  }

  
}