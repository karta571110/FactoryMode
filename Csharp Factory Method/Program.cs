using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_Factory_Method
{
    /*
     * 工廠方法模式( Factory Method )，定義一個用於建立物品的介面，
     * 讓子類決定實體化哪一個類別。
     * 工廠方法使一個類別的實例化延遲到其子類別。-- 大話設計模式 p.105
*/
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Operation oper = null;

                Console.Write("請輸入數字A:");
                string strNumberA = Console.ReadLine();
                Console.Write("請選擇運算符號(+、-、*、/):");
                string strOperate = Console.ReadLine();
                Console.Write("請輸入數字B:");
                string strNumberB = Console.ReadLine();

                oper = OperationFactory.createOperate(strOperate);

                oper.NumberA = Double.Parse(strNumberA);
                oper.NumberB = Double.Parse(strNumberB);

                string strResult = string.Empty;

                strResult = Convert.ToString(oper.GetResult());

                Console.WriteLine("答案:" + strResult);
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine("輸入有誤:" + ex);
            }
                
        }
    }
}


