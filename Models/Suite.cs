namespace DesadioHospedagem;

public class Suite
{
  public string TipoSuite {get;private set;}
  public int Capacidade {get;private set;}
  public double ValorDiaria {get;private set;}

  public Suite (string tipoSuite, int capacidade, int valorDiaria){
    TipoSuite = tipoSuite;
    Capacidade = capacidade;
    ValorDiaria = valorDiaria;
  }
}
