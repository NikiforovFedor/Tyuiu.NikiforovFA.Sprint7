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
        string content = "������, ���!\r\n�;�����;C#;\r\n�;������������;\r\n��;���������;";
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
            { "������, ���!" },
            { "�", "�����", "C#" },
            { "�", "������������" },
            { "��", "���������" }
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