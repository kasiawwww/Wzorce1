using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce1.AbstractFactory
{
    public class CSVEditor : IFileEditor
    {
        string path;
        public CSVEditor(string path)
        {
            this.path = path;
        }
        public void Add(string text)
        {
            File.AppendAllText(path, $"{Environment.NewLine}{text}");
        }

        public void ClearAllText()
        {
            File.WriteAllText(path, String.Empty);
        }

        public void Remove(string text)
        {
            string[] fileText = File.ReadAllLines(path);
            ClearAllText();
            foreach (var item in fileText)
            {
                Add(item.Replace(text, ""));
            }
        }
    }
}
