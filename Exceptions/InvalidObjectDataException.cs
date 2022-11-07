namespace Model.Exceptions;


/// <summary>
/// Esta excessão é lançada quando se é checado e descoberto que alguma propriedade do objeto seja considerada inválida.
/// </summary>
public class InvalidObjectDataException : InvalidDataException
{
    public InvalidObjectDataException(string dado) : base(dado)
    {

    }

    public override string Message => $"Propriedade '{Dado}' deste objeto é inválida.";
}
