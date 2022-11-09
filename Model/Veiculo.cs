namespace Model;

public class Veiculo
{
    public int Id { get; set; }
    public string Placa { get; set; }

    public Veiculo(string placa)
    {
        Placa = placa;
    }
}