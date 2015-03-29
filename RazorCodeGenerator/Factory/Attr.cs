namespace RazorCodeGenerator.Factory {
    public static class Attr {
        public static Attribute Class(string className) {
            return new Attribute("class", className);
        }
        public static Attribute Style(string styleValue) {
            return new Attribute("style", styleValue);
        }
        public static Attribute Name(string value) {
            return new Attribute("name", value);
        }
        public static CompoundAttribute Data(string dataName, string value) {
            return new CompoundAttribute("data",dataName,value);
        }
        public static CompoundAttribute Aria(string ariaName, string value) {
            return new CompoundAttribute("aria", ariaName, value);
        }
    }
}