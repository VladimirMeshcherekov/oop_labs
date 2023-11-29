using InterfaceLab.Interfaces;

namespace lab3
{
    internal class ProgramHelper : ProgramConverter, ICodeChecker
    {
        public bool CodeCheckSyntax(string code, string language)
        {
            if (language == "CS")
            {
                if (code == "CS code")
                {
                    return true;
                }

                return false;
            }


            if (language == "VB")
            {
                if (code == "VB code")
                {
                    return true;
                }

                return false;
            }
            
            return false;
        }
    }
}