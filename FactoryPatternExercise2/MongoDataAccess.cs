using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class MongoDataAccess : IDataAcess
    {
        public class MongoDataAcess
        {
        }
        public List<Product> LoadData()
        {
            Console.WriteLine($"(I am reading data from: Mono database");
            return new List<Product>() { new Product { product = "tablet", price = 1500 } };
        }
        public void SaveData()
        {
            Console.WriteLine($" “I am saving data to a Mongo database”");
        }
    }
}
