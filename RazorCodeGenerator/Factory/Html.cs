using RazorCodeGenerator.HtmlNodes;
using Attribute = RazorCodeGenerator.Attributes.Attribute;

namespace RazorCodeGenerator.Factory
{
    public static class Html
    {
        public static HtmlContainerNode Div(params Attribute[] attributes) {
            return new HtmlContainerNode("div", attributes);
        }

        public static HtmlSelfClosingNode Input(params Attribute[] attributes) {
            return new HtmlSelfClosingNode("input",attributes);
        }

        public static HtmlContainerNode Span(params Attribute[] attributes) {
            return new HtmlContainerNode("span",attributes);
        }

        public static HtmlContainerNode Label(params Attribute[] attributes) {
            return new HtmlContainerNode("label", attributes);
        }
    }

}
