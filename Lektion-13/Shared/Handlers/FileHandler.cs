using System.Diagnostics;

namespace Shared.Handlers;

public class FileHandler
{
    public static void SaveToFile(string path, string content)
    {
        try
        {
            using var sw = new StreamWriter(path);
            sw.WriteLine(content);
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
    }

    public static string ReadFromFile(string path)
    {
        try
        {
            if (File.Exists(path)) { 
               return File.ReadAllText(path);
            }
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }

        return null!;
    }
}
