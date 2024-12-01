
namespace lab3_oop
{
    class FileWriter
    {
        public void WriteFile(string filePath, string content)
        {
            File.WriteAllText(filePath, content);
        }
    }
}