using Tyuiu.BilousEYu.Sprint5.Task6.V21.Lib;
namespace Tyuiu.BilousEYu.Sprint5.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Елизавета\source\repos\Tyuiu.BilousEYu.Sprint5\DataSprint5\InPutDataFileTask6V21.txt";

            int wait = 3;

            var res = ds.LoadFromDataFile(path);
            
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.BilousEYu.Sprint5\DataSprint5\InPutDataFileTask6V21.txt";
            
            
            FileInfo fileInfo = new FileInfo(path);
            bool fileexists = fileInfo.Exists;
            bool expect = true;
            Assert.AreEqual(expect, fileexists);
        }
    }
}