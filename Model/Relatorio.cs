namespace Model;

public class Relatorio
{
    public int Id { get; set; }
    public Enums.CancelaEnum Cancela { get; set; }
    public Enums.TipoRegistroEnum TipoRegistro { get; set; }
    public DateTime DataRegistro { get; set; }
    public bool Resultado { get; set; }
    public Veiculo VeiculoId { get; set; }
}