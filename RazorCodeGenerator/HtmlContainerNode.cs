using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RazorCodeGenerator {
    public class HtmlContainerNode : HtmlNode {

        public NodeCollection Elements { get; private set; } 

        public HtmlContainerNode(string type, params Attribute[] attributes) : base(type, attributes) {
            Elements = new NodeCollection();
        }

        public override string Generate() {
            var sb = new StringBuilder();
            sb.Append("<" + Name + HtmlAttributes.GenerateHtmlAttributes()+">");
            sb.Append(Elements.Generate());
            sb.Append("</ " + Name + ">");
            return sb.ToString();
        }
    }
}