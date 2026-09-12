//引用命名空间
//命名空间
using System.Data.Common;
using System.Formats.Asn1;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Lesson2_变量
{
    //类
    internal class Program
    {
        //主函数 程序主入口
        static void Main(string[] args)
        {
            //函数语句块 目前学的内容 都在这里
            Console.WriteLine("变量");

            //知识点一 折叠代码
            //主要作用 是让我们编程时 逻辑更加清晰
            //它的有 #rigion #endregion配对出现
            //它的具体作用 之可以将中间包裹起来的代码折叠起来 避免代码太过凌乱
            //本质是 编程器提供个我们的 预处理令
            //它只会在编辑时有用 发布了代码 或执行代码 它会被自动删除
            #region 知识点二 如何申明变量
            //变量 可以变化的容器
            //变量 就是用来储存各种不同类型数值的一个容器
            //不同的 变量类型 可以存储不同类型的值

            //变量申明固定写法
            //变量类型 变量名=初始值;
            //int i= 1;
            //变量类型 有14种变化
            //变量名 我们自定义  要按照一定规则
            //初始值 一定要和变量类型是统一
            //=和;是固定的 不变的

            //变量类型
            //一定要死记硬背 各种变量类型的关键字、
            //一定要记忆 各种不同变量类型 所能存储的范围
            //一定要记忆 各种不同变量类型 所能存储的类型

            //1.有符号的整形变量 是能存储 一定范围 正负数包括0的变量类型
            //sbyte -128~127
            sbyte sb = 1;
            //潜在知识点 通过+来进行拼接打印
            Console.WriteLine("sbyte变量sb存储的值是："+sb);
            //int   -21亿~21亿多
            int i= 2;
            //short -32768~32767之间的数
            short s = 3;
            //long -9百万兆~9百万兆之间的数
            long l = 4;


            //2.无符号的整形变量 是能存储 一定范围 0和正数的变量类型
            //byte 0~255
            byte b = 1;
            //uint 0~42亿多的一个范围
            uint u = 2;
            //ushort 0~65535之间的一个数
            ushort v = 3;
            //ulong 0~18百万兆
            ulong ui = 4;
            

            //3.浮点数（小数）
            //float 存储7~8位有效数字 根据编译器的不同 有效数字也可能不一样 四舍五入
            //有效数字 是从左到右非0数开始计算有效数字的
            //之所以要在后面加f,m 是因为c# 申明的小鼠 默认是double的类型 加发 是告诉系统 它是float
            float f =0.1234567890f;
            Console. WriteLine(f);
            //double存储15~17位有效数字 抛弃的小数 会四舍五入
            double d = 0.12345678901234567890123456789;
            Console.WriteLine(d);
            //decimal 存储27~28位的有效数字 不常用
            decimal de = 0.123456789012345678901234567890m;
            Console.WriteLine(de);

            //4.特殊类型
            //bool true false 表示真假的数据类型 真假类型
            bool bo = true;
            bool bo3 = false;
            Console.WriteLine(bo+"_"+bo3);

            //char 是用来存储单个字符的变量类型 字符类型
            char c = '2';
            Console.WriteLine(c);

            //string是字符串类型 用来存储多个字符的 没有上限
            string str = "fhjbhiogjs国库就是个汇入";
            Console.WriteLine(str);

            int x = 132;
            //申明变量
            Console.WriteLine(x);
            //变量的使用和修改 不能无中生有 必须要先申明才能用
            x = 423;
            //修改变量
            Console.WriteLine(x);

            #endregion

            #region 知识点三 为什么有那么多不同的变量类型
            //不同变量类型 存储的范围和类型不一样 本质是占用的内存空间不同
            //选择不同的数据（变量）类型装在不同的数据

            //姓名
            //char string
            string myName = "linxianzheng";
            //年龄
            byte age = 18;
            //身高
            float height = 180.9f;
            //体重
            float weight = 50.9f;
            //性别 true 女 false男
            bool sex = false;

            //数字用int 小数用float 字符串用string 真假用bool
            #endregion

            #region 知识点四 多个 相同类型变量 同时申明
            int i2 = 1;
            float f2 = 3.6f;
            string str2 = "wnm";
            bool b2 = true;
            //多个同个类型变量申明
            //固定写法
            //变量类型 变量名=初始值，变量名=初始值，变量名=初始值……；
            int a1 = 1, b1 = 2, c1 = 3, d5 = 4;
            Console.WriteLine(b1);
            string s1 = "1", s2 = "234";
            Console.WriteLine(s2+s1);
            #endregion

            #region 知识点五 变量初始化相关
            //变量申明时 可以不设置初始值 但是不建议这样写 这样不安全
            int a2;
            //可以后面在申明变量值
            a2 = 1;
            Console.WriteLine(a2);

            #endregion





        }
    }
}
