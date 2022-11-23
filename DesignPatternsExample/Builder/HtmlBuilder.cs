using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExample.Builder
{
    public class HtmlBuilder
    {
        HtmlElement root = new HtmlElement();
        private readonly string rootname;
        public HtmlBuilder(string name)
        {
            rootname = name;
            root.Name = name;
        }
        public void addchild(string name,string text)
        {
           var child = new HtmlElement(name,text);
           root.AddToElement(child.ToString()); 
        }

    }
}
