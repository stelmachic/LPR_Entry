namespace Model.Exceptions;


/// <summary>
/// Esta excessão representa a existência de uma referência de um objeto em outro objeto no Banco de Dados.
/// </summary>
public class ReferenceInAnotherObjectException : ObjectExistanceException
{
    public override string Message => $"Objeto está referenciado em outro objeto no Banco de Dados.";
}
