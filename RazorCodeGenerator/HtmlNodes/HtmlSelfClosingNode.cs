using RazorCodeGenerator.Attributes;

namespace RazorCodeGenerator.HtmlNodes {
    public class HtmlSelfClosingNode : INode {

        public string Name { get; private set; }

        public AttributeCollection HtmlAttributes { get; private set; }

        public HtmlSelfClosingNode(string name, params IAttribute[] attributes)
        {
            Name = name;
            HtmlAttributes = new AttributeCollection(attributes);
        }

        public string Generate() {
            return "<" + Name + HtmlAttributes.GenerateHtmlAttributes() + " />";
        }
    }
}