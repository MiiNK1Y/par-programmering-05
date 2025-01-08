namespace ConsoleApp1
{
    internal class Overview
    {
        private List<Store> Stores;

        public Overview()
        {
            Stores = new List<Store>()
            {
                new Store("Colleen's", "underwear", 3),

                new Store("Geir's Crack Shack", "crack", 1),
                new Store("Julie's Crack Shack", "crack", 3),
                new Store("Bethina's Crack Shack", "crack", 1),

                new Store("Lars' Shroom Journey", "shrooms", 1),
                new Store("Stephanies' Holy Shrooms", "shrooms", 1),

                new Store("Gytis Meth Muffins", "meth muffins", 2),
                new Store("Henrik's Meth Muffins", "meth muffins", 1),
                new Store("Kristian's Meth Muffins", "meth muffins", 2),

                new Store("William's Weed Gummies", "weed gummies", 3),
                new Store("Thomas' Weed Gummies", "weed gummies", 3),
                new Store("Kim' Weed Gummies", "weed gummies", 2)
            };
        }
        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.Write(
                    "What would you like to do: \n" +
                    "1. Add store\n2. Show all stores\n" +
                    "3. Show stores by price class\n" +
                    "4. Show stores by specialty\n" +
                    "5. Exit app\n" +
                    "Your input ~> "
                );

                string input = Console.ReadLine() ?? "";
                switch (input)
                {
                    case "1":
                        AddStore();
                        break;
                    case "2":
                        ShowAllStores();
                        break;
                    case "3":
                        ShowByPriceClass();
                        break;
                    case "4":
                        ShowBySpeciality();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Not a valid input...");
                        Thread.Sleep(1000);
                        break;
                }
            }
        }
        private void AddStore()
        {
            Store newStore = new Store();
            newStore.SetStoreInfo();
            Stores.Add(newStore);
        }

        public void ShowAllStores()
        {
            Console.Clear();
            Console.WriteLine(
                "All available stores\n" +
                "--------------------"
            );

            foreach (Store s in Stores) { s.PrintStoreInfo(); }
            Console.ReadLine();
        }

        public void ShowByPriceClass()
        {
            Console.Clear();
            Console.Write("Which price class to sort by: ");

            int input = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine(
                $"All stores sorted by class [{input}]\n" +
                "-------------------------------"
            );

            foreach (Store s in Stores)
            {
                if (s.PriceClass == input) { s.PrintStoreInfo(); }
            }
            Console.ReadLine();
        }

        private List<string> GetAllSpecialities()
        {
            List<string> storeSpecialities = new List<string>();

            for (int i = 0; i < Stores.Count; i++)
            {
                string storeSpeciality = Stores[i].Specialty;
                if (!storeSpecialities.Contains(storeSpeciality))
                {
                    storeSpecialities.Add(storeSpeciality);
                }
            }

            return storeSpecialities;
        }

        public void ShowBySpeciality()
        {
            Console.Clear();

            List<string> storeSpecialities = GetAllSpecialities();
            foreach (string store in storeSpecialities) { Console.WriteLine(store); }

            Console.Write("\nWhich store type to show: ");

            string input = Console.ReadLine() ?? "";

            Console.Clear();
            Console.WriteLine(
                $"All stores sorted by [{input}]\n" +
                "-------------------------------"
            );

            foreach (Store s in Stores)
            {
                if (s.Specialty == input) { s.PrintStoreInfo(); }
            }
            Console.ReadLine();
        }
    }
}
