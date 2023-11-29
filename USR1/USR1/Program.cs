namespace USR1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Client client1 = new Client();
            
        }
    }
    
    class Client
    {
        public readonly ObjectStructure Structure;
        
        public Client()
        { 
            Structure = new ObjectStructure();
            Structure.Add(new Family());
            Structure.Add(new Fabric());
            Structure.Accept(new InsuranceAgent());
        }
    }
    
    
}