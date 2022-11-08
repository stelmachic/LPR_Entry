namespace Model.Exceptions;


/// <summary>
/// Esta excessão é lançada quando um objeto a ser atualizado ou deletado do Banco de Dados não existe no mesmo.
/// </summary>
public class ObjectDoesntExistException : ObjectExistanceException
{
    public override string Message => $"Objeto não existe no Banco de Dados.";
}
