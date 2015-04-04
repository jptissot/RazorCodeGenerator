using System.Text;

namespace RazorCodeGenerator.RazorNodes {
    public class RazorElseStatement : IRazorContainer
    {
        public RazorElseStatement() {
            Elements = new NodeCollection();
        }

        public NodeCollection Elements { get; private set; }
        public string Generate() {
            var sb = new StringBuilder();
            sb.Append("else{");
            sb.Append(Elements.Generate());
            sb.Append("}");
            return sb.ToString();
        }

    
    }
}