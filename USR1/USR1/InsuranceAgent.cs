namespace USR1
{
    internal class InsuranceAgent : IVisitor
    {
   
     public void VisitElementA(Family elemA)
     {
         elemA.GetInsurance2();
     }

     public void VisitElementB(Fabric elemB)
     {
         elemB.GetInsurance1();
     }
    }
}