using System.Text;

namespace RazorCodeGenerator.RazorNodes {
    public class RazorIfStatement : IRazorContainer
    {
        public RazorIfStatement(string condition, params INode[] nodes) {
            Condition = condition;
            Elements = new NodeCollection(nodes);
        }

        public string Condition { get; private set; }
        public NodeCollection Elements { get; private set; }

        public string Generate() {
            var sb = new StringBuilder();
            sb.Append("if(" + Condition + "){");
            sb.Append(Elements.Generate());
            sb.Append("}");
            return sb.ToString();
        }

      
    }
}