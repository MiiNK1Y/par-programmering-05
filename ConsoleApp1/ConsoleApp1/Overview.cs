using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                new Store("Gytis Meth Muffins", "meth muffins", 2),
                new Store("Henrik's Meth Muffins", "meth muffins", 1),
                new Store("William's Weed Gummies", "weed gummies", 3),              
                new Store("Thomas' Weed Gummies", "weed gummies", 3)            
            };
        }
        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do: \n1. Add store\n2. Show all stores\n3. Show stores by price class\n4. Exit app");
                string input = Console.ReadLine();
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
                        Environment.Exit(0);
                        break;
                    default:
                        throw new Exception("No printers");
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
            foreach (Store s in Stores)
            {
                s.PrintStoreInfo();
            }
            Console.ReadLine();
        }

        public void ShowByPriceClass()
        {
            Console.WriteLine("Which price class to sort by: ");
            int input = Convert.ToInt32(Console.ReadLine());
            foreach (Store s in Stores)
            {
                if (s.PriceClass == input)
                {
                    s.PrintStoreInfo();
                }
            }
        }
    }
}
