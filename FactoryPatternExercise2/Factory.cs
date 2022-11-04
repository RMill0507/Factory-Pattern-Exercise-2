using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class Factory

    {
        public static IDataAccess GetDataAccess(string dataBaseType)
        {
            switch (dataBaseType)
            {
                case "list":
                    return new ListDataAccess();
                case "mongo":
                    return new MongoDataAccess();
                case "sql":
                    return new SQLDateAccess();
                default:
                    return new ListDataAccess();
                    

                   
            }
        }
    }
}
