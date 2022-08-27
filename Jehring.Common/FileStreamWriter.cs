using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Jehring.Common
{
    public static class FileStreamWriter
    {
        public static void WriteToFile(this Stream stream, string filePath)
        {
            using (Stream output = File.Create(filePath))
                CopyStream(stream, output);
        }

        private static void CopyStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[8192];
            int count;
            while ((count = input.Read(buffer, 0, buffer.Length)) > 0)
                output.Write(buffer, 0, count);
        }
    }
}
