using System;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 值类型
            //溢出检测
            //UInt32 invalid = unchecked((UInt32) (- 1));
            //Console.WriteLine(invalid);

            //Byte b = 100;
            //b = (Byte)(b + 200);//
            //Console.WriteLine($"b:{b}");
            //checked
            //{
            //    Byte b = 100;
            //    b = (Byte)(b + 200);//抛出异常

            //}

            //Decimal a = 0.999999999999M;
            //Console.WriteLine(a);

            //System.Numerics.BigInteger bigInteger = new System.Numerics.BigInteger(9999999999999999999999999);//错误
            //Console.WriteLine(bigInteger); 
            #endregion


            Console.ReadKey();
        }
    }
}
