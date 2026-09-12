using System;

namespace lesson14_位运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //位运算符 主要用数值类型进行计算的
            //将数值转换为2进制 再进行位运算
           
            #region 知识点- 位与 &
            //规则 连接两个数值进行位计算 将数值转为2进制
            //对位运算 有0则0
            int a = 1;// 001
            int b = 5;//101
           
             //  001
             //& 101
             //  001
            int c = a & b;
            Console.WriteLine(c);

            //多个数值进行位运算 没有括号时 从左到右 依次计算
            a=1;// 001
            b = 5;// 101
            c= 19;//10011
            //  00001
            //& 00101
            //  00001
            //& 10011
            // 00001
            int d=a& b&c;
            Console.WriteLine(d);

            a = 1;//001
            b=2;  //010
            Console.WriteLine(a & b);


            #endregion

            #region 知识点二 位或 |
            //规则 连接两个数值进行位计算 将数值转为2进制
            // 对位运算 有1则1

            a = 1;//001
            b = 3;//011
            c=a| b;
                  // 001
                  //| 011
                  // 011
            Console.WriteLine(c);
            a = 5;
            b = 10;
            c= 20;
            Console.WriteLine(c);

            #endregion

            #region 知识点 三异或 ^
            // 规则 连接两个数值进行位计算 将数值转为2进制
            // 对位运算 相同为0 不同为1
            a = 1; //001
            b = 5;//101
                  // 001
                  //^101
                  // 100
            c = a ^ b; 
            Console.WriteLine(c);

            a = 10;  // 1010
            b = 11; // 1011
            c = 4;  //100

            // 1010
            //^1011
            // 0001
            //^0100
            // 0101
            d = a ^ b ^ c;
            Console.WriteLine(d);//5
            #endregion

            #region 知识点四 位取反~
            // 规则 写在数值前面 将数值转为2进制
            // 对位运算 8变1 1变0
            a = 5;
            // 8000 0000 0000 0000 0000 0000 0000 0101
            // 1111 1111 1111 1111 1111 1111 1111 1010
            //反码补码知识
            c = ~a;
            Console.WriteLine(c);
            #endregion

            #region 左移<< 和 右移>>
            //规则 让一个数的2进制数进行左移和右移
            //左移几位 右侧加几个0
            a = 5;// 101
            c=a<<5;
            // 1位 1010
            // 2位 10100
            // 3位 101000
            // 4位 1010000
            //5位10100000=32 + 128 = 160
            Console.WriteLine(c);
            
            //右移几位 右侧去掉几个数
            a = 5;// 101
            c = a >> 2;
            // 1位 10
            // 2位 1
            Console.WriteLine(c);

            #endregion
        }
    }
}
