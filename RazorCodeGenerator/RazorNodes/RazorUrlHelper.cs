using System.Text;

namespace RazorCodeGenerator.RazorNodes {
    public class RazorUrlHelper : IRazorStringProvider {
        public RazorUrlHelper(string action) {
            Action = action;
        }
        public RazorUrlHelper(string action, string controller)
        {
            Controller = controller;
            Action = action;
        }
        public RazorUrlHelper(string action, string controller, string routeValues) {
            RouteValues = routeValues;
            Controller = controller;
            Action = action;
        }

        public string Action { get; private set; }
        public string Controller { get; private set; }
        public string RouteValues { get; private set; }
        public string Generate() {
            var sb = new StringBuilder();
            sb.Append("@Url.Action(\""+Action+"\"");
            if(!string.IsNullOrEmpty(Controller)) {
                sb.Append(",\"" + Controller + "\"");
            }
            if (!string.IsNullOrEmpty(RouteValues))
            {
                sb.Append(",\"" + RouteValues + "\"");
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}