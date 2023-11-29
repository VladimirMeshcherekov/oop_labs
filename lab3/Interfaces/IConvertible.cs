namespace InterfaceLab.Interfaces
{
    internal interface IConvertible
    {
        string ConvertToCSharp(string code);
        
        string ConvertToVB(string code);
    }
}
