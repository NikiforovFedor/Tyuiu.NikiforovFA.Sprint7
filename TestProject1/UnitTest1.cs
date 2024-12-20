using NUnit.Framework;
using System.IO;
using System.Text;
using Tyuiu.NikiforovFA.Sprint7.Project.V3.Lib;

[TestFixture]
public class OpenFileTests
{
    private string _testFilePath;

    [SetUp]
    public void Setup()
    {
        _testFilePath = Path.Combine(Path.GetTempPath(), "testfile.csv");
        string content = "Привет, мир!\r\nЯ;люблю;C#;\r\nИ;тестирование;\r\nНа;кириллице;";
        File.WriteAllText(_testFilePath, content, Encoding.UTF8);
    }

    [TearDown]
    public void TearDown()
    {
        File.Delete(_testFilePath);
    }

    [Test]
    public void OpenFile_WithCyrillicContent_ReturnsCorrectArray()
    {
        // Arrange
        string[,] expectedArray = {
            { "Привет, мир!" },
            { "Я", "люблю", "C#" },
            { "И", "тестирование" },
            { "На", "кириллице" }
        };

        // Act
        string[,] result = OpenFile(_testFilePath);

        // Assert
        Assert.AreEqual(expectedArray.GetLength(0), result.GetLength(0));
        Assert.AreEqual(expectedArray.GetLength(1), result.GetLength(1));

        for (int i = 0; i < expectedArray.GetLength(0); i++)
        {
            for (int j = 0; j < expectedArray.GetLength(1); j++)
            {
                Assert.AreEqual(expectedArray[i, j], result[i, j]);
            }
        }
    }
}