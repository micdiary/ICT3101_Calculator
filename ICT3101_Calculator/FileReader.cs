    public interface IFileReader
    {
        string[] Read(string path);
    }

    public class FileReader : IFileReader
    {
        public string[] Read(string path)
        {
            return File.ReadAllLines(path);
        }
    }