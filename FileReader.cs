

namespace lab3_oop
{
    class FileReader
    {
        public string ReadFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}