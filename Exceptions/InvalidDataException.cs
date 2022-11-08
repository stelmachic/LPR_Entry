namespace Model.Exceptions;


/// <summary>
/// Esta excessão representa a descoberta de dados inválidos em um objeto.
/// </summary>
public class InvalidDataException : BeneficiosException
{
    public string Dado;

    public InvalidDataException(string dado)
        => Dado = dado;

    public override string Message => $"Propriedade \"{Dado}\" deste objeto é inválida.";
}
