namespace DesadioHospedagem;

public class Reserva
{
  public List<Pessoa> Hospedes { get; set; }
  public Suite Suite { get; set; }
  public int DiasReservados { get; set; }

  public Reserva(int diasReservados) => DiasReservados = diasReservados;

  public void CadastrarHospedes (List<Pessoa> hospedes){
    if(Suite.Capacidade >= hospedes.Count){
      Hospedes = hospedes;
    }else{
      throw new Exception("Quantidade de hóspedes excede a capacidade da suite");
    }
  }  

  public void CadastrarSuite(Suite suite){
    Suite = suite;
  }

  public int ObterQuantidadeHospedes(){
    return Hospedes.Count;
  }

  public double CalcularValorDiaria(){
    double valorDiaria = DiasReservados * Suite.ValorDiaria;
    if(DiasReservados >= 10){
      valorDiaria -= valorDiaria * 0.1;
    }
    return valorDiaria;
  }
}
