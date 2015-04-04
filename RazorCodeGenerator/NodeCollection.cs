using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using RazorCodeGenerator.RazorNodes;

namespace RazorCodeGenerator {
    public class NodeCollection {
        private readonly Collection<INode> _nodes;

        public NodeCollection() {
            _nodes = new Collection<INode>();
        }
        public NodeCollection(IList<INode> nodes)
        {
            _nodes = new Collection<INode>(nodes);
        }

        public T Add<T>(T node) where T : INode
        {

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