using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace RazorCodeGenerator {
    public abstract class HtmlNode : Node {
        public string Name { get; private set; }

        public AttributeCollection HtmlAttributes { get; private set; }

        protected HtmlNode(string name , params Attribute[] attributes) {
            Name = name;
            HtmlAttributes = new AttributeCollection(attributes);
        }
    }
}