using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce1.Builder.FileBuild
{
    public interface IFileBuildable
    {
        void CreateFile();
        void SetText(string text);
        string Path { get; set; }
    }
}
