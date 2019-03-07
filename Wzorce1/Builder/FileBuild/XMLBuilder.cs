using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce1.Builder.FileBuild
{
    public class XMLBuilder : IFileBuildable
    {
        public string Path { get; set; }
        public void CreateFile()
        {
           File.Create(Path).Close();
        }
        public void SetText(string text)
        {
            if (File.Exists(Path))
            {
                using (StreamWriter sw = new StreamWriter(Path))
                {
                    sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
                    sw.WriteLine("<root><value>");
                    sw.WriteLine(text);
                    sw.WriteLine("</value></root>");
                }
            }
        }
    }
}
