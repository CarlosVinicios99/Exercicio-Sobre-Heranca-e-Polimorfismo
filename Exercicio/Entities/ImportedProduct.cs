namespace Exercicio.Entites
{
    class ImportedProduct : Product
    {
        public double CustomsFee {get; set;}

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return $"{Name} U$ {TotalPrice():F2} Customs Fee: U$ {CustomsFee:F2}";
        }

        public double TotalPrice()
        {
            return Price += CustomsFee;
        }
    }
}