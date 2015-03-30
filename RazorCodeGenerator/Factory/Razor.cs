using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorCodeGenerator.Factory
{
    public static class Razor
    {
        public static RazorIfStatement If(string cond) {
            return new RazorIfStatement(cond);
        }
    }
}
