using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExample.Builder
{
    public class HtmlElement
    {
        public string Name { get; set; }
        public string Text { get; set; }

        public HtmlElement()
        {

        }
        public HtmlElement(string name,string text)
        {
            Name = name;
            Text = text;
        }

        private string ToStringElement()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"<{Name}>");
            sb.AppendLine(Text);
            sb.AppendLine("</>");
            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringElement();
        }
        public void AddToElement(string element)
        {
            Text=Text + element;
        }
    }
}
