namespace OPD.Domain.Entities.Products
{
    public class Product : Base
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public bool Isavaliable { get; set; }
    }
}
