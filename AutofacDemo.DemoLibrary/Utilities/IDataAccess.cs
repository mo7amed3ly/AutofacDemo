namespace AutofacDemo.DemoLibrary.Utilities
{
    public interface IDataAccess
    {
        string GetData();
        void SaveData(string data);
    }
}