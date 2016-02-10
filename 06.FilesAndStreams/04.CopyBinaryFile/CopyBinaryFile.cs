using System;
using System.IO;

class CopyBinaryFile
{
    static void Main()
    {
        File.Copy("koala.jpg", "copy-koala.jpg", false);
    }
}
