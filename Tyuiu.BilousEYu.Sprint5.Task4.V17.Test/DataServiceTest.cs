using Tyuiu.BilousEYu.Sprint5.Task4.V17.Lib;
namespace Tyuiu.BilousEYu.Sprint5.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\User\source\repos\BilousEYu.Sprint5\DataSprint5\InPutDataFileTask4V17.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}