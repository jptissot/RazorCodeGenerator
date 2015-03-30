using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace RazorCodeGenerator {
    public class AttributeCollection {
        private readonly Collection<Attribute> _attributes;
        public AttributeCollection() {
            _attributes = new Collection<Attribute>();
        }
        public AttributeCollection(IList<Attribute> attributes)
        {
            _attributes = new Collection<Attribute>(attributes);
        }

        public T Add<T>(T attribute) where T : Attribute {
            _attributes.Add(attribute);
            return attribute;
        }
        public string GenerateHtmlAttributes()
        {
            var sb = new StringBuilder();

            foreach (var attributeName in _attributes.DistinctBy(e => e.GetName()).Select(n => n.GetName()))
            {
                //the leading space is very important here as calling code depends on it.
                sb.Append(" " + attributeName + "=\"" + GetAttributeValue(attributeName) + "\"");
            }

            return sb.ToString();
        }
        public string GenerateRazorAttributesAnonymousObject()
        {
            var sb = new StringBuilder();
            sb.Append("new {");
            foreach (var attributeName in _attributes.DistinctBy(e => e.GetName()).Select(n => n.GetName()))
            {
                sb.Append(GetRazorAttributeName(attributeName) + "=\"" + GetAttributeValue(attributeName) + "\",");
            }
            //remove last comma
            sb.Remove(sb.Length - 1, 1);
            sb.Append("}");

            return sb.ToString();
        }

        private string GetAttributeValue(string attributeName)
        {
            var sb = new StringBuilder();
            foreach (var htmlAttribute in _attributes.Where(h => h.GetName() == attributeName))
            {
                sb.Append(htmlAttribute.GetValue() + " ");
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        private static string GetRazorAttributeName(string name) {
            if(name == "class" || name == "id") {
                return "@"+name;
            }
            if(name.Contains("-")) {
                return name.Replace("-", "_");
            }
            return name;
        }
    }
}