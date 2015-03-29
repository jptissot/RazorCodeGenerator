namespace RazorCodeGenerator {
    /// <summary>
    /// Used to represent attributes that have a dash seperating ie: data attributes or aria attributes
    /// </summary>
    public class CompoundAttribute : Attribute {
        private readonly string _prefix;

        public CompoundAttribute(string prefix, string name, string value) : base(name, value) {
            _prefix = prefix;
        }

        public override string GetName() {
            return _prefix + "-" + GetName();
        }
    }
}