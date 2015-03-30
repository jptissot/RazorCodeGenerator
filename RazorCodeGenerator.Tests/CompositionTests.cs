using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorCodeGenerator.Factory;

namespace RazorCodeGenerator.Tests
{
    [TestClass]
    public class CompositionTests
    {
        [TestMethod]
        public void TestSimpleComposition() {
            var div = Html.Div(Attr.Class("someClass"), Attr.Style("display:none"));
            div.Elements.Add(Html.Input(Attr.Name("SomeName")));

            var res = div.Generate();
            Assert.IsTrue(!string.IsNullOrEmpty(res));
        }

        [TestMethod]
        public void TestRazorIfComposition() {
            var div = Html.Div();
            var ifNode = div.Elements.Add(Razor.If("1 > 5"));
            ifNode.Elements.Add(Html.Span(Attr.Class("someSpan")));

            var res = div.Generate();
            Assert.IsTrue(!string.IsNullOrEmpty(res));

        }
        [TestMethod]
        public void TestRazorHelperComposition()
        {
            var div = Html.Div();
            var label = div.Elements.Add(Html.Label(Attr.For("someId")));
            label.Elements.Add(Razor.DropdownHelper("someId", "Model.SelectListAccessor", Attr.Id("someId")));
        }
    }
}
