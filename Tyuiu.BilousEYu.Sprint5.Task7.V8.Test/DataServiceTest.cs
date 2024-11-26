using Tyuiu.BilousEYu.Sprint5.Task7.V8.Lib;
namespace Tyuiu.BilousEYu.Sprint5.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\User\source\repos\Tyuiu.BilousEYu.Sprint5\DataSprint5\OutPutDataFileTask7V8.txt";

            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);
        }
    }
}