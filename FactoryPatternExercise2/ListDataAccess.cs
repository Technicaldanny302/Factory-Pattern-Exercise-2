using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAcess
    {
        public ListDataAccess()
        {
        }
        public List<Product> LoadData()
        {
            Console.WriteLine($"(I am reading data from: List");
            return new List<Product>() { new Product {product = "iphone", price = 800 } };
        }
        public void SaveData()
        {
            Console.WriteLine($" “I am saving data to a List database”");
        }

    }
}
