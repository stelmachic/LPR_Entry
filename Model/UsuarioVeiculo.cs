namespace Model;

public class UsuarioVeiculo
{
    public int Id { get; set; }
    public Usuario Usuario { get; set; }
    public Veiculo Veiculo { get; set; }
}