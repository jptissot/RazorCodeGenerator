using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorCodeGenerator.RazorNodes;

namespace RazorCodeGenerator.Factory
{
    public static class Razor
    {
        public static RazorIfStatement If(string cond) {
            return new RazorIfStatement(cond);
        }

        public static RazorRawHelper Raw(string parameter) {
            return new RazorRawHelper(parameter);
        }

        public static RazorModelValueAcessor Model(string valueAccessor) {
            return new RazorModelValueAcessor(valueAccessor);
        }
    }
}
