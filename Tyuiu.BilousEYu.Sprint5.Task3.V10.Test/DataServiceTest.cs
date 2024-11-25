using Tyuiu.BilousEYu.Sprint5.Task3.V10.Lib;
namespace Tyuiu.BilousEYu.Sprint5.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(fileExists, wait);
        }
    }
    
}