using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace RazorCodeGenerator {
    public abstract class Node {
        public abstract string Generate();
    }

    //@{ some code }
    public class RazorCodeBlock {
            
    }

    //var x = somevalue
    public class RazorAssignment {
        
    }
    //if(statement)    for(statement) else //
    public abstract class RazorContainerNode : Node {
        public NodeCollection Elements { get; private set; }

        protected RazorContainerNode() {
            Elements = new NodeCollection();
        }
    }

    //public class RazorForLoop : RazorContainerNode {
        
    //}

    public class RazorIfStatement : RazorContainerNode {
        public RazorIfStatement(string condition) {
            Condition = condition;
        }

        public string Condition { get; private set; }

        public override string Generate() {
            var sb = new StringBuilder();
            sb.Append("@if(" + Condition + "){");
            sb.Append(Elements.Generate());
            sb.Append("}");
            return sb.ToString();
        }
    }

    public class RazorElseStatement : RazorContainerNode
    {
        public override string Generate() {
            var sb = new StringBuilder();
            sb.Append("else{");
            sb.Append(Elements.Generate());
            sb.Append("}");
            return sb.ToString();
        }
    }


    public class RazorBaseHelper {
        public RazorBaseHelper(string name) {
            Name = name;
        }

        public string Name { get; private set; }
    }

    //@Model.Value
    public class RazorStringHelper : RazorBaseHelper
    {
        public string ValueAccessor { get;private set; }

        protected RazorStringHelper(string name,string valueAccessor) : base(name) {
            ValueAccessor = valueAccessor;
        }
    }

    public class RazorRawHelper : RazorBaseHelper
    {
        public string Parameter { get; private set; }
        public RazorRawHelper(string parameter):base("Html") {
            Parameter = parameter;
        }
    }

    public class RazorInputHelper : RazorBaseHelper
    {
        public AttributeCollection Attributes { get; set; }
        private readonly string _helperName;
        private readonly string _param1;
        private readonly string _param2;

        public RazorInputHelper(string helperName, string param1, string param2, params Attribute[] attributes) :base("Html") {
            _helperName = helperName;
            _param1 = param1;
            _param2 = param2;
            Attributes = new AttributeCollection(attributes);
        }
    }
}