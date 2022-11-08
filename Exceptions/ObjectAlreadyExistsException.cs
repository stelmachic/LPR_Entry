namespace Model.Exceptions;


/// <summary>
/// Esta excessão é lançada quando um objeto a ser salvo no Banco de Dados já existe no mesmo.
/// </summary>
public class ObjectAlreadyExistsException : ObjectExistanceException
{
    public override string Message => $"Objeto já existente no Banco de Dados.";
}
