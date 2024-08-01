using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAcess
    {
        public SQLDataAccess()
        {
        }
        public List<Product> LoadData()
        {
            Console.WriteLine($"(I am reading data from: SQL database");
            return new List<Product>() { new Product { product = "computer", price = 1800 } };
        }
        public void SaveData()
        {

        }
    }    
}
