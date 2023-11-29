namespace InterfaceLab.Interfaces
{
    internal interface ICodeChecker
    {
        bool CodeCheckSyntax(string code, string language);
    }
}
