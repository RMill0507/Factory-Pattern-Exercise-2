using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class ListDataAccess : IDataAccess
    {
        public ListDataAccess()
        {

        }

        public void LoadData()
        {
            Console.WriteLine("I loading the data from the List");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to the List ");
        }
    }
}
