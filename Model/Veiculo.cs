namespace Model;

public class Veiculo
{
    public int Id { get; set; }
    public string Placa { get; set; }
    public bool Cadastrado { get; set; }

    public Veiculo(string placa)
    {
        Placa = placa;
    }
}