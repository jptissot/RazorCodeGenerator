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
    }
}
