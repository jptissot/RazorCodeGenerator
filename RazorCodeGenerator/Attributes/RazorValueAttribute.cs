using RazorCodeGenerator.RazorNodes;

namespace RazorCodeGenerator.Attributes {
    public class RazorValueAttribute : IAttribute {
        private readonly string _name;
        private readonly IRazorStringProvider _provider;

        public RazorValueAttribute(string name, IRazorStringProvider provider) {
            _name = name;
            _provider = provider;
        }

        public string GetName() {
            return _name;
        }

        public string GetValue() {
            return _provider.Generate();
        }
    }
}