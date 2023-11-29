using System;
using InterfaceLab.Interfaces;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProgramConverter[] converters = new ProgramConverter[2];
            converters[0] = new ProgramConverter();
            converters[1] = new ProgramHelper();

            foreach(var converter in converters)
            {
                if(converter is ICodeChecker checker)
                {
                    string input = converter.ConvertToCSharp("sdjkhflhjskdjdkFHjkshekjfihskjdfjklhasdkjfhkjsdhfjklshd");
                    bool isWorking = checker.CodeCheckSyntax(input, "CS");
                    Console.WriteLine("Is working:" + Convert.ToString(isWorking));
                }
                else
                {
                    Console.WriteLine("ICodeChecker is not working at: " + Convert.ToString(converter.GetType()));
                }
            }
        }
    }
}
