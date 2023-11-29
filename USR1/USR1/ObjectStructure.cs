using System.Collections.Generic;

namespace USR1
{
    class ObjectStructure
    {
        List<InsuranceUser> elements = new List<InsuranceUser>();
        public void Add(InsuranceUser insuranceUser)
        {
            elements.Add(insuranceUser);
        }
        public void Remove(InsuranceUser insuranceUser)
        {
            elements.Remove(insuranceUser);
        }
        public void Accept(IVisitor visitor)
        {
            foreach (InsuranceUser element in elements)
                element.Accept(visitor);
        }
    }
}