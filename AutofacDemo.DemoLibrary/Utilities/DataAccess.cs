using System;

namespace AutofacDemo.DemoLibrary.Utilities
{
    public class DataAccess : IDataAccess
    {
        public DataAccess() { }
        public void SaveData(string data)
        {
            Console.WriteLine($"Saving data: {data}");
        }

        public string GetData()
        {
            Console.WriteLine("Getting data");
            return "Data";
        }
    }
}
