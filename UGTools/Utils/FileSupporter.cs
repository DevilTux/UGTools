using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UGTools.Utils
{
    public class FileSupporter
    {
        public static FileSupporter Intance
        {
            get{ return new FileSupporter();}
        }

        public string ReadTextFromFile(string filePath)
        {
            var result = new StringBuilder();
            const int bufferSize = 16384;
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream,Encoding.UTF8))
            {
                var fileContents = new char[bufferSize];

                var count = bufferSize;
                while (count > 0)
                {
                    count = streamReader.Read(fileContents, 0, bufferSize);
                    result.Append(fileContents);
                }
            }
            return result.ToString();
        }
    }
}
