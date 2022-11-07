namespace Model.Exceptions;


public class UserPermissionException : SessionException
{
    public override string Message => $"Permissão negada. O usuário não possui a permissão necessária para executar a ação atual.";
}
