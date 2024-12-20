using Tyuiu.NikiforovFA.Sprint7.Project.V3.Lib;
namespace Tyuiu.NikiforovFA.Sprint7.Project.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void OpenFileValid()
        {
            DataService ds = new DataService();
            string path = "C:\\DataSprint7\\Data.csv";
            string[,] wait = new string[2, 3];
            wait[0, 0] = "1";
            wait[0, 1] = "osu";
            wait[0, 2] = "23";
            wait[1, 0] = "2";
            wait[1, 1] = "osu1";
            wait[1, 2] = "4";



            CollectionAssert.AreEqual(ds.OpenFile(path), wait);
        }
    }
}