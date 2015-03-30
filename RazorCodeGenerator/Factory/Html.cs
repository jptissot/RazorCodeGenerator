using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorCodeGenerator
{
    public static class Html
    {
        public static HtmlContainerNode Div(params Attribute[] attributes) {
            return new HtmlContainerNode("div", attributes);
        }

        public static HtmlNode Input(params Attribute[] attributes) {
            return new HtmlSelfClosingNode("input",attributes);
        }

        public static HtmlContainerNode Span(params Attribute[] attributes) {
            return new HtmlContainerNode("span",attributes);
        }

        public static HtmlContainerNode Label(params Attribute[] attributes)
        {
            return new HtmlContainerNode("label", attributes);
        }
    }

}
