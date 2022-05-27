class Frete {
  private double distancia, peso;
  public Frete(double distancia, double peso) {
    this.distancia = distancia;
    this.peso = peso;
  }
  public double getDistancia() {
    return distancia;
  }
  public double getPeso() {
    return peso;
  }
  public void setDistancia(double distancia) {
    this.distancia = distancia;
  }
  public void setPeso(double peso) {
    this.peso = peso;
  }
  public double calcFrete() {
    return 0.01 * distancia * peso;
  }  
  public String toString() {
    return String.format("Distância = %f km, Peso = %f kg", distancia, peso);
  }
}

class Program {
  public static void main(String[] args) {
    Frete f = new Frete(100, 10);
    System.out.println(f);
    System.out.println(f.getDistancia());
    System.out.println(f.getPeso());
    System.out.println(f.calcFrete());
    f.setDistancia(150);
    System.out.println(f);
    System.out.println(f.calcFrete());
  }
}