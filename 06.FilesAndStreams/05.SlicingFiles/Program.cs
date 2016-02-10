using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class SlicingFile
{
    static List<string> files = new List<string>();

    static void Main(string[] args)
    {
        string sourcePath = "Koala.jpg";
        string resultPath = "result/";

        Directory.CreateDirectory(Path.GetDirectoryName(resultPath));
        int parts = int.Parse(Console.ReadLine());

        Slice(sourcePath, resultPath, parts);
        Assemble(files, sourcePath, resultPath);
    }

    static void Slice(string sourcePath, string resultPath, int parts)
    {
        using (var source = new FileStream(sourcePath, FileMode.Open))
        {
            long a = source.Length;
            int sizeOfChunk = (int)Math.Ceiling((double)source.Length / parts);
            for (int i = 1; i <= parts; i++)
            {
                using (var result = new FileStream(resultPath + Path.GetFileNameWithoutExtension(sourcePath) + "-" + i + Path.GetExtension(sourcePath), FileMode.Create))
                {
                    files.Add(resultPath + Path.GetFileNameWithoutExtension(sourcePath) + "-" + i + Path.GetExtension(sourcePath));
                    while (result.Position < sizeOfChunk)
                    {
                        byte[] buffer;
                        if (sizeOfChunk > 4096) buffer = new byte[4096];
                        else buffer = new byte[sizeOfChunk];

                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        result.Write(buffer, 0, readBytes);

                        if (readBytes <= 0 || result.Position >= sizeOfChunk)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }

    static void Assemble(List<string> files, string sourcePath, string resultPath)
    {
        using (var result = new FileStream(resultPath + Path.GetFileName(sourcePath), FileMode.Create))
        {
            for (int i = 0; i < files.Count; i++)
            {
                using (var source = new FileStream(files[i], FileMode.Open))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        result.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
