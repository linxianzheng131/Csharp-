//第一种注释 两杠注释
//第二种注释 星号注释
//第三种注释 三杠注释

//，。每年的十字路口然后就干咳
//hi认同的喜欢v宝宝
//9i二氧化硅那边

///命名空间 ---工具包
namespace lesson1
{
    //命名空间 代码块
    //面向对象相关内容知识点 会来回来这里写代码

    /// <summary>
    /// 类---工具
    /// </summary>
    internal class Program
    {
        //类 代码块
        //面向对象相关内容知识点 会来回来这里写代码
        /// <summary>
        /// 函数---工具能做的事情
        /// 主函数 一个程序的主入口
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //函数代码块 目前所学基础内容
            //所有的代码都是写在这个代码块中
            //在控制台 打印出 你好世界这个内容
            //在控制台打印一行信息 打印一行信息结束后 自动空一行
            Console.WriteLine("你好世界!");
            //程序语句

            Console.WriteLine("我嫰蝶");
            //如果是双引号之间，对于符号没有特别要求
            //在控制台打印信息 但是打印完后 不会自动空行
            Console.Write("王者荣耀我日尼玛");
            Console.Write("你个sb东西");
            Console.WriteLine("请玩家输入");

            //检测玩家输入的代码
            //等待玩家输入完毕后（按回车） 才会继续执行后面的代码
            //玩家可以输入很多信息 直到回车结束
            Console.ReadLine();

            Console.WriteLine("玩家输入完毕");
            
            //检测玩家是否按键 只要按了键盘上的任意键 就会认为输入结束
            Console.ReadKey();

            Console.WriteLine("玩家输入完毕");

            //输入 向控制台输入内容
            //Console.ReadLine();
            //Console.ReadKey();
                ///()不写内容
            //输出 在控制台打印信息
            //Console.WriteLine();
            //Console.Write();

        }
    }
}
