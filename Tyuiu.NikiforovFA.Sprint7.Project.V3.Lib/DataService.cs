using System.Text;
using System.IO;
namespace Tyuiu.NikiforovFA.Sprint7.Project.V3.Lib
{
    public class DataService
    {
        public string[,] OpenFile(string path)
        {
            int rows;
            int columns;
            string FileData = File.ReadAllText(path, Encoding.UTF8);
            FileData = FileData.Replace('\n', '\r');

            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            string[,] array = new string[rows, columns];
            int k = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] l = line.Split(';');
                    for (int i = 0; i < l.Length; i++)
                    {
                        array[k, i] = l[i].Trim();
                    }
                    k++;
                }
            }
            return array;
        }    
    }
}
