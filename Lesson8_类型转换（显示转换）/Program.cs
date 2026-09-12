using System.ComponentModel.Design.Serialization;

namespace Lesson8_类型转换_显示转换_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("显示转换");

            //显示转换——>手动处理 强制转换

            #region 知识点一 括号强转
            //作用 一般情况下 将高精度的类型强制转换为低精度
            //语法 变量类型 变量名 = （变量类型）变量名
            //注意 精度问题 范围问题

            //相同大类的整形
            //有符号（无符号）整形
            sbyte sb = 1;
            short s = 2;
            int i = 3;
            long l = 4;
            s = (short)i;

            byte b = 1;
            ushort us = 2;
            uint ui = 3;
            ulong ul = 4;

            b = (byte)us;

            //浮点之间
            float f = 1.2f;
            double d = 1.3;
            decimal de = 1.34m;//decimal 过于不常用所以不讨论了

            f = (float)d;


            //无符号和有符号
            ui = (uint)i;
            //再强转时 一定要注意范围 不然得到的结果 可能异常（范围问题）

            //浮点与整形 浮点数强转成整形时 会直接去掉小数 且不会四舍五入（精度问题）
            i = (int)1.24f;

            //char和数值类型
            char c = (char)i;
            Console.WriteLine(c);
            //bool和string
            bool bo = true;
            //bool不支持用括号显示转化
            string st = "142";
            //string也不支持用括号显示转化

            #endregion

            #region 知识点二 Parse法
            //作用：把字符串类型转换为对应的类型
            //语法：变量类型.Parse（"字符串"）
            //注意：字符串必须能够转换成对应类型 并且范围也要合法 否则报错
            //有符号
            int i4 = int.Parse("124");
            // 字符串必须能够转换成对应类型 并且范围也要合法 否则报错
            sbyte sb3 = sbyte.Parse("2");
            Console.WriteLine(sb3);
            //他们的意思是相同的
            Console.WriteLine(sbyte.Parse("2"));
            Console.WriteLine(long.Parse("1234234"));
            //无符号
            Console.WriteLine(uint.Parse("2"));
            //浮点数
            float fe = float.Parse("1.4");
            Console.WriteLine(float.Parse("1.4"));
            //特殊类型
            bool b5 = bool.Parse("true");
            char c4 = char.Parse("5");
            //string没有这种用法


            #endregion

            #region 知识点三 Converst法
            //作用：更准确的将 各个类型之间进行相互转换
            //语法：Convert.To目标类型（变量或常量）
            //注意：填写的变量或常量必须正确 否则出错

            //转字符串 如果是把字符串转成对应类型 那字符串一定要合法合规
            int a = Convert.ToInt32("12");

            //精度更准确
            a = Convert.ToInt32(4.23456m);
            Console.WriteLine(a);
            //精度比括号强转好一点 会四舍五入
            a = Convert.ToInt32(4.587f);
            Console.WriteLine(a);
            //特殊类型转换

            //把bool类型也可以转成 数值类型 true对应1 false对应0
            a = Convert.ToInt32(true);
            Console.WriteLine(a);
            a = Convert.ToInt32(false);
            Console.WriteLine(a);

            a = Convert.ToInt32('A');
            Console.Write(a);


            //每一个类型都存在对应的 Convert中的方法
            sbyte sb5 = Convert.ToSByte("2");
            short s8 = Convert.ToInt16("1");
            int i7= Convert.ToInt32("2");
            long l6 = Convert.ToInt64("4");

            byte b4 = Convert.ToByte("34");
            ushort us2 = Convert.ToUInt16("2");
            uint ui6 = Convert.ToUInt32("2");
            ulong ul3 = Convert.ToUInt64("3");

            float f5 = Convert.ToSingle("13.2");
            double d4 = Convert.ToDouble("23,56");
            decimal dw=Convert.ToDecimal("7.3");

            bool bo3 = Convert.ToBoolean("true");
            char c5 = Convert.ToChar("3");

            string str = Convert.ToString(326587);

            #endregion

            #region 知识点四 其他类型转string
            //作用：拼接打印
            //语法：变量.ToString();

            string str8 = 1.ToString();
            str8 = true.ToString();
            str8 = 's'.ToString();
            str8 = 1.3f.ToString();

            int d3 = 3;
            str8 = d3.ToString();
            bool bee = true;
            str8 = bee.ToString();
            //当我们进行字符串拼接时 就自动会运用ToString 转成 string
            Console.WriteLine("2535"+3+true);

            str8 = "iute" + 3 + true;

            #endregion

            #region 练习题3 学习存储玩家输入信息的方法
            //提示用户输入姓名和成绩，并将输入的成绩用整形变量存储

            Console.WriteLine("请输入你的姓名");
            string str4 = Console.ReadLine();
            //这步是存储信息 存储的是玩家输入的姓名内容（以字符串的形式）

            Console.WriteLine("请输入你的成绩");
            string str6 = Console.ReadLine();
            //这步是存储信息 存储的是玩家输入的成绩内容（以字符串的形式）
           
            Console.WriteLine(str4+str6);
            //后面需要时可以引用存储的变量名进行使用

            int chengji = int.Parse(str6);
            //这部是将字符串用整型变量的形式存储

            Console.WriteLine(str6);
            //但是如果玩家输入的成绩不是数字就会报错
            #endregion
        }
    }
}
