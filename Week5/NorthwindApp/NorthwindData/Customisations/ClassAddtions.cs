namespace NorthwindData
{
    public partial class Customer
    {
        public override string ToString()
        {
            return $"{CustomerId} - {ContactName} - {City} - {Country}";
        }
    }
}
