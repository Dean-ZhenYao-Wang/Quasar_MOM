namespace MOM.Application.Wrappers
{
    public interface ITranslator
    {
        string this[string name]
        {
            get;
        }

        string GetString(string name);
        string GetString(TranslatorMessageDto input);
    }
}
