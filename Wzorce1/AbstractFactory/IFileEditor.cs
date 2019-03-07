using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce1.AbstractFactory
{
    public interface IFileEditor
    {
        void Add(string text);
        void Remove(string text);
        void ClearAllText();
    }
}
