namespace RazorCodeGenerator.Attributes {
    /// <summary>
    /// Used to represent attributes that have a dash seperating ie: data attributes or aria attributes
    /// </summary>
    public class CompoundAttribute : IAttribute {
        private readonly string _prefix;
        private readonly string _name;
        private readonly string _value;

        public CompoundAttribute(string prefix, string name, string value) {
            _prefix = prefix;
            _name = name;
            _value = value;
        }

        public string GetName() {
            return _prefix + "-" + _name;
        }

        public string GetValue() {
            return _value;
        }
    }
}