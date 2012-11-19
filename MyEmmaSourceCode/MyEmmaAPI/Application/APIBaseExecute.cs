using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyEmmaApi.Methods
{
    public abstract class APIBaseExecute
    {
        protected MyEmmaBaseInput Input { get; private set; }
        
        


        protected virtual void APiRun(MyEmmaBaseInput input)
        {
            
            ExecuteJson(); // we can add access type enum to MyEmmaBaseInput to execute xml or Json
        }

        protected abstract void ExecuteJson();
        

    }

    
}
