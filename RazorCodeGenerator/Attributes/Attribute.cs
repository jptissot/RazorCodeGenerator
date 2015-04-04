namespace RazorCodeGenerator.Attributes {
    public class Attribute : IAttribute {
        private readonly string _name;
        private readonly string _value;

        public Attribute(string name, string value) {
            _name = name;
            _value = value;
        }

        public virtual string GetName() {
            return _name;
        }

        public virtual string GetValue() {
            return _value;
        }
    }
}