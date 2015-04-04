namespace RazorCodeGenerator.RazorNodes {
    public interface IRazorContainer : INode {
        NodeCollection Elements { get; }
    }
}