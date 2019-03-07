using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce1.AbstractFactory
{
    class AbstractFactory
    {
        public static IFileEditor GetFileEditor(string path)
        {
            IFileEditor editor = null;
            string[] array = path.Split('.');
            string extention = array[array.Length - 1];
            switch (extention)
            {
                case "txt":
                    editor = new TextEditor(path);
                    break;
                case "xml":
                    editor = new XMLEditor(path);
                    break;
                case "csv":
                    editor = new CSVEditor(path);
                    break;
                default:
                    throw new Exception("Nie znany typ edytora");
            }
            return editor;
        }
    }
}
