using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_Factory_Method
{
    class OperationFactory
    {
        public static Operation createOperate(string operate)
        {

            Operation oper = null;
            switch (operate)
            {
                case "+":
                    oper = new OperationWay.OperationAdd();
                    break;
                case "-":
                    oper = new OperationWay.OperationSub();
                    break;
                case "*":
                    oper = new OperationWay.OperationMul();
                    break;
                case "/":
                    oper = new OperationWay.OperationDiv();
                    break;
                default:
                    Console.WriteLine("輸入錯誤!");
                    Console.ReadKey();
                    break;
            }

            return oper;
        }
    }
}
