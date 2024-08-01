namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which database will you like to use ? sql, mongo, or list?");
            var response = Console.ReadLine();

            var answer = DataAccessFactory.GetDataAccessType(response);
            answer.LoadData();
            answer.SaveData();
        }
    }
}
