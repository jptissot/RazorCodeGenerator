using System.Text;
using RazorCodeGenerator.Attributes;

namespace RazorCodeGenerator.HtmlNodes {
    public class HtmlContainerNode : INode {

        public string Name { get; private set; }

        public AttributeCollection HtmlAttributes { get; private set; }

    
        public NodeCollection Elements { get; private set; }

        public HtmlContainerNode(string name, params IAttribute[] attributes)
        {
            Name = name;
            Elements = new NodeCollection();
            HtmlAttributes = new AttributeCollection(attributes);
        }

        public string Generate() {
            var sb = new StringBuilder();
            sb.Append("<" + Name + HtmlAttributes.GenerateHtmlAttributes()+">");
            sb.Append(Elements.Generate());
            sb.Append("</" + Name + ">");
            return sb.ToString();
        }
    }
}