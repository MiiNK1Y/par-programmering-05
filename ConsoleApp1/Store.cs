namespace ConsoleApp1
{
    internal class Store
    {
        public string Name { get; private set; }
        public string Specialty { get; private set; }
        public int PriceClass { get; private set; }

        public Store() { }

        public Store(string name, string specialty, int priceClass)
        {
            Name = name;
            Specialty = specialty;
            PriceClass = priceClass;
        }

        public void PrintStoreInfo()
        {
            Console.WriteLine($"{Name} | {TranslatePriceClass()} | {Specialty}");
        }

        public void SetStoreInfo()
        {
            SetStoreName();
            SetStoreSpecialty();
            SetItemsPriceClass();
        }

        public void SetStoreName()
        {
            Console.Write("Name of store: ");
            Name = Console.ReadLine() ?? "";
        }

        public void SetStoreSpecialty()
        {
            Console.Write("Specialty: ");
            Specialty = Console.ReadLine() ?? "";
        }

        public void SetItemsPriceClass()
        {
            Console.Write("Items' price class (1-3): ");
            PriceClass = Convert.ToInt32(Console.ReadLine());
        }

        private string TranslatePriceClass()
        {
            switch (PriceClass)
            {
                case 1:
                    return "Cheap";
                case 2:
                    return "Average priced";
                case 3:
                    return "Very expensive";
                default:
                    return "This should never print";
            }
        }
    }
}
