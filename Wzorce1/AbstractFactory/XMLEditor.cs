using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Wzorce1.AbstractFactory
{
    public class XMLEditor : IFileEditor
    {
        string path;
        public XMLEditor(string path)
        {
            this.path = path;
        }
        public void Add(string text)
        {
            var xd = XDocument.Load(path);
            XElement element = new XElement("value");
            element.Value = text;
            xd.Element("root").Add(element);
            xd.Save(path);
        }
        public void ClearAllText()
        {
            var xd = XDocument.Load(path);
            xd.Element("root").Elements("value").Remove();
            xd.Save(path);
        }
        public void Remove(string text)
        {
            var xd = XDocument.Load(path);
            xd.Element("root").Elements("value").Where(e => e.Value.Contains(text)).Remove();
            xd.Save(path);
        }

    }

}   

