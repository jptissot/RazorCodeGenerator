using RazorCodeGenerator.Attributes;

namespace RazorCodeGenerator.Factory {
    public static class Attr {
        public static Attribute Id(string idValue) {
            return new Attribute("id", idValue);
        }
        public static Attribute Class(string classValue) {
            return new Attribute("class", classValue);
        }
        public static Attribute Style(string styleValue) {
            return new Attribute("style", styleValue);
        }
        public static Attribute For(string value)
        {
            return new Attribute("for", value);
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