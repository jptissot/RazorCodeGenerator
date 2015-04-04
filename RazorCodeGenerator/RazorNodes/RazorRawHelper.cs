namespace RazorCodeGenerator.RazorNodes {
    public class RazorRawHelper : IRazorStringProvider
    {
        public string Parameter { get; private set; }
        public RazorRawHelper(string parameter) {
            Parameter = parameter;
        }

        public string Generate() {
            return "@Html.Raw(" +Parameter+ ")";
        }
    }
}