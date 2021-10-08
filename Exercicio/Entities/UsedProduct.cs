using System; 

namespace Exercicio.Entites
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate {get; set;} 

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) U$ {Price:F2} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")}";
        }
    }
}