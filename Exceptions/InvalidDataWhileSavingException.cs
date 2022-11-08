namespace Model.Exceptions;


/// <summary>
/// Esta excessão é lançada quando um objeto tenta ser salvo com suas listas de objetos não estando vazias.
/// </summary>
public class InvalidDataWhileSavingException : InvalidDataException
{
    public InvalidDataWhileSavingException(string dado) : base(dado)
    {

    }
    
    public override string Message => $"Propriedade \"{Dado}\" deve estar vazia ao ser salvar no Banco de Dados.";
}
