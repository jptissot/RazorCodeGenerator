using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace RazorCodeGenerator {
    public class NodeCollection {
        private Collection<Node> _nodes;

        public NodeCollection() {
            _nodes = new Collection<Node>();
        }
        public NodeCollection(Collection<Node> nodes) {
            _nodes = nodes;
        }

        public T Add<T>(T node) where T:Node{

            if(node is RazorElseStatement) {
                var last = _nodes.LastOrDefault();
                if(last != null && !(last is RazorIfStatement)) {
                    throw new ArgumentException("Can only add else statement after if statement");
                }
            }
            _nodes.Add(node);
            return node;
        }

        public string Generate() {
            var sb = new StringBuilder();
            foreach (var node in _nodes) {
                sb.Append(node.Generate());
            }

            return sb.ToString();
        }
    }
}