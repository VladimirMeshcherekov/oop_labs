using System;

namespace USR1
{
    class Fabric : InsuranceUser
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitElementB(this);
        }

        public void GetInsurance1()
        {
            Console.WriteLine("Была продана защита от нашествия ящеров");
        }
    }
}