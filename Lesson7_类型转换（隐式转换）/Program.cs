namespace Lesson7_类型转换_隐式转换_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("隐式转换");
            //类型转换的含义

            //类型转换 就是不同的相互转换

            //隐式转换的基本规则就是不同类型之间自动转换
            //大范围装小范围

            //隐式转换方式
            //方式一
            //初始化后 转换结果= 转换目标 大=小 小转换成为大
            long l_ = 1;
            int i_= 2;
            l_ = i_;
            //通过 ''在初始化时转化为char
            int i__ = '5';
            #region 知识点一 相同类型之间的相互转换

            //有符号long->int->short->sbyte
            long l = 1;
            int i = 2;
            short s = 3;
            sbyte sb = 4;
            //隐式转换 interesting隐式转换成了long
            l = i;
            l = s;
            //i不等于l 反之可以 下面也是不可以反过来 即大范围装小范围
            i = s;
            s = sb;

            //无符号 ulong->uint->ushort->byte
            byte b = 5;
            uint ui = 6;
            ushort us = 7;
            ulong ul = 8;
            //同上 

            //浮点数 double->float      decimal
            decimal de = 1.22m;
            double d = 1.23;
            float f = 1.32f;
            //decimal这个类型 没有办法用隐式转换的形式去存储 double和float

            //特殊类型 bool char string
            //不存在隐式转换
            bool bo= true;
            char c = 'y';
            string st = "ui";
            #endregion

            #region 知识点二 不同大类型之间的转换

            #region 无符号和有符号之间
            //无符号装有符号——不能够有隐式转换
            //有符号装无符号——部分可以
            //规则：范围大就可以装
            i = b;
            l = b;
            l = ui;

            #endregion

            #region 浮点数的整数（有、无符号）之间
            //double->float->所有整形（有符号，无符号）
            //decimal->所有整形（有符号，无符号）
            //浮点数装整数
            f = ul;
            f = l;
            //浮点数是可以装任意整数
            f = 1000000000000000000;
            //浮点数的范围都是超过整数
            de = ul;
            //decimal可以装整型
            //整数装浮点数    不行隐式转换整数不能装小数
            #endregion

            #region 特殊类型和其他类型之间
            //bool bool没有办法和其他类型 相互隐式转换

            //char char没有办法隐式的存储 其他类型的变量

            //但是char类型可以隐式转换成 整形和浮点数
            //char隐式转换成 数值类型是 对应的的数字 其实是一个 ASCII码
            //计算机里面存储 2进制
            //符号 中文 英文 标点符号 在计算机中都是一个数字
            //一个字符 对应一个数字关系 ASCII就是一种对应关系
            i = c;
            f = c;
            ui = c;

            //string string没有办法和其他类型 相互隐式转换

            #endregion

            //总结 隐式转换 规则
            //高精度（大范围）装低精度（小范围）

            #endregion

            #region 练习题一
            
            #endregion

            #region 练习题二

            #endregion


        }
    }
}
