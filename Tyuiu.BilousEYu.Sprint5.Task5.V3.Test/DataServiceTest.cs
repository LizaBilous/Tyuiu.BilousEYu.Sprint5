using Tyuiu.BilousEYu.Sprint5.Task5.V3.Lib;
namespace Tyuiu.BilousEYu.Sprint5.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {

            string path = @"C:\Users\Елизавета\source\repos\Tyuiu.BilousEYu.Sprint5\DataSprint5\InPutDataFileTask5V3.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}