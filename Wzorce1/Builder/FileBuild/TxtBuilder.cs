using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce1.Builder.FileBuild
{
    public class TxtBuilder : IFileBuildable
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
                File.WriteAllText(Path, text);
            }
        }
    }
}
