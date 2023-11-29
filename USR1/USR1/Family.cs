using System;

namespace USR1
{
    class Family : InsuranceUser
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitElementA(this);
        }

        public void GetInsurance2()
        {
            Console.WriteLine("Была продана защита от того что ребёнок не станет тиктокером");
        }
    }
}