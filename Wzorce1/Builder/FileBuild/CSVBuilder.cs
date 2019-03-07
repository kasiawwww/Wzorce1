using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce1.Builder.FileBuild
{
    public class CSVBuilder: IFileBuildable
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
                    sw.WriteLine(@"tekscik;");
                    sw.WriteLine(String.Format(@"{0};", text));
                }            
            }
        }
    }
}
