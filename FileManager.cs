using lab3_oop;
using System.Text.Json;

namespace lab3_oop
{
    class FileManager
    {
        private FileReader fileReader = new FileReader();
        private FileWriter fileWriter = new FileWriter();
        private FileSerializer fileSerializer = new FileSerializer();

        public FileManager() { }

        private bool DeserializeFile(string content)
        {
            try
            {
                var file = Schedule.GetInstance();
                file.Data = fileSerializer.Deserialize(content);
                return true;
            }
            catch (JsonException)
            {
                return false;
            }
        }

        public void SaveFile()
        {
            var file = Schedule.GetInstance();
            var json = fileSerializer.Serialize(file.Data);
            fileWriter.WriteFile(file.FilePath, json);
        }

        public bool OpenFile(string filePath)
        {
            var file = Schedule.GetInstance();
            file.FilePath = filePath;
            file.FileContent = fileReader.ReadFile(filePath);
            return DeserializeFile(file.FileContent);
        }
    }
}