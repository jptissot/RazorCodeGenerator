using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

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
    //if(condition)    for(condition) else //
    public class RazorContainerNode {

    }


    public class RazorHelper {
        
    }
}