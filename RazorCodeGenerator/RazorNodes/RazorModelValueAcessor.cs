namespace RazorCodeGenerator.RazorNodes {
    public class RazorModelValueAcessor : IRazorStringProvider
    {
        public string ValueAccessor { get;private set; }

        public RazorModelValueAcessor(string valueAccessor)
        {
            ValueAccessor = valueAccessor;
        }

        public string Generate() {
            return "@Model." + ValueAccessor;
        }
    }
}