using System.Collections.Generic;
using System.IO;

public class FileSaver
{
    public void SaveListToFile<T>(List<T> list, string filepath)
    {
        using (StreamWriter writer = new StreamWriter(filepath))
        {
            foreach (T item in list)
            {
                writer.WriteLine(item.ToString());
            }
        }
    }
}