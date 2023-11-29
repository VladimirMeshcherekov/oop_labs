using IConvertible = InterfaceLab.Interfaces.IConvertible;

namespace lab3
{
    internal class ProgramConverter: IConvertible
    {
        public string ConvertToCSharp(string code)
        {
            return "CS code";
        }

        public string ConvertToVB(string code)
        {
            return "VB code";
        }
    }
}
