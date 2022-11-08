namespace Model.Exceptions;


public class UserNotLoggedException : SessionException
{
    public override string Message => $"Usuário não logado no sistema.";
}
