namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dataAccessType;
            bool input = false;
            do
            {
                Console.WriteLine("Enter the data access type you would like to use:");

               dataAccessType = (Console.ReadLine().ToLower());
            }while (input == true);
            var data = Factory.GetDataAccess(dataAccessType);
            data.LoadData();
            data.SaveData();
            
            
            
            
        }
    }
}
