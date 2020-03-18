using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_Factory_Method.OperationWay
{
    /// <summary>
    /// 加法
    /// </summary>
  public  class OperationAdd : Operation
    {
      public override double GetResult()
        {
            double result = 0;

            result = NumberA + NumberB;

            return result;
        }

   
    }
    /// <summary>
    /// 減法
    /// </summary>
    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;

            result = NumberA - NumberB;

            return result;
        }


    }
    /// <summary>
    /// 乘法
    /// </summary>
    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;

            result = NumberA * NumberB;

            return result;
        }


    }
    /// <summary>
    /// 除法
    /// </summary>
    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
                throw new Exception("除數不能為零");

            result = NumberA / NumberB;

            return result;
        }
    }
}
