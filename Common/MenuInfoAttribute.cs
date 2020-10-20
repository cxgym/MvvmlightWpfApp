using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmlightWpfApp.Common
{
    [AttributeUsage(AttributeTargets.Class)]
    [MetadataAttribute]
    public class MenuInfoAttribute : Attribute
    {
        public string Key { get; }
        public MenuInfoAttribute(string key)
        {
            Key = key;
        }
    }
}
