using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatternFirstLesson1
{

    //step 1:create interface
    public interface Strategy <t>
    {
        t doOpertation(t num1, t num2);
    }
    //step 2:Create concrete classes implementing the same interface.
    public class OperationAdd<t> : Strategy<t>
    {
        public t doOpertation(t num1, t num2)
        {
            dynamic tnum1 = num1;
            dynamic tnum2 = num2;
            return tnum1 + tnum2;
        }
    }
    public class OperationSubstract<t>:Strategy<t>
    {
        public t doOpertation(t num1, t num2)
        {
            dynamic tnum1 = num1;
            dynamic tnum2 = num2;
            return tnum1 - tnum2;
        }
    }
    public class OperationMultiply<t> : Strategy<t>
    {
        public t doOpertation(t num1, t num2)
        {
            dynamic tnum1 = num1;
            dynamic tnum2 = num2;
            return tnum1 * tnum2;
        }
    }
    // step 3:Create Context Class.
     public class ContextStartgeyPattern<t>
    {
        private Strategy<t> stg;
        public ContextStartgeyPattern(Strategy<t> stg)
        {
            this.stg = stg;
        }

        public t executeStrategy(t num1,t num2)
        {
           return this.stg.doOpertation(num1, num2);
        }
    }


}
