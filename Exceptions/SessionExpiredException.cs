namespace Model.Exceptions;


public class SessionExpiredException : SessionException
{
    public DateTime Data;

    public SessionExpiredException(DateTime data)
        => Data = data;

    public override string Message => $"Sessão encerrada há \"{DateTime.Now - Data}\". Inicie um nova sessão (Login).";
}
