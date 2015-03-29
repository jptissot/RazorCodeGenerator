namespace RazorCodeGenerator {
    public class HtmlSelfClosingNode : HtmlNode {
        public HtmlSelfClosingNode(string name, params Attribute[] attributes) : base(name, attributes) {}

        public override string Generate() {
            return "<" + Name + HtmlAttributes.GenerateHtmlAttributes() + " />";
        }
    }
}