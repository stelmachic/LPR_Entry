namespace Model.Exceptions;


public class InvalidLoginException : SessionException
{
    public override string Message => $"Login não existe no Banco de Dados.";
}
