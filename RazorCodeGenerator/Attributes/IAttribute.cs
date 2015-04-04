namespace RazorCodeGenerator.Attributes {
    public interface IAttribute {
        string GetName();
        string GetValue();
    }
}