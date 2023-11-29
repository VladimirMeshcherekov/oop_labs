namespace USR1
{
    abstract class InsuranceUser
    {
        public abstract void Accept(IVisitor visitor);
        public string SomeState { get; set; }
    }
}