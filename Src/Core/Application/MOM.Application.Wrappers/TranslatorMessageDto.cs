namespace MOM.Application.Wrappers
{
    public struct TranslatorMessageDto(string text, string[] args)
    {
        public string Text { get; set; } = text;
        public string[] Args { get; set; } = args;
    }
}