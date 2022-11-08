namespace Model.Exceptions;


public class UserNotRegisteredException : SessionException
{
    public override string Message => $"Usuário não cadastrado no Sistema.";
}
