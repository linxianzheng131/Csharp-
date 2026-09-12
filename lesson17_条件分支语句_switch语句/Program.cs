namespace lesson17_条件分支语句_switch语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("switch语句");
            #region 知识点一 作用
            //让顺序执行的代码 产生分支
            #endregion

            #region 知识点二 基本语法
            //case和break之间可以写n句语句
            // 并且可以嵌套使用 也可以嵌套if等
            //switch (变量)
            //{
            //    变量 == 常量 执行 case和 break之间的代码
            //    case 常量:
            //        满足条件执行的代码逻辑;
            //        break:
            //    case 常量:
            //        满足条件执行的代码逻辑;
            //        break;
            //    case 可以有无数个
            //    default:
            //        如果上面case的条件都不满足 就会执行 default中的代码
            //    break;
            //}
            // 注意: 常量!! 只能写一个值 不能去写一个范围 不能写条件运算符啊 逻辑运算符
            //switch 只判断变量是否等于某一个固定值!!
            //这个一般适配和枚举使用
            int a = 3;
            switch (a)
            {
                //条件一定是一个常量 
                case 1:
                    Console.WriteLine("a=1");
                    break;
                case 2:
                    Console.WriteLine("a=2");
                    break;
                case 3:
                    Console.WriteLine("a=3");
                    break;
                    default:
                    Console.WriteLine("什么条件都不满足");
                    break;
            }
            #endregion

            #region 知识点三 dafault可省略
            //像else一样
            string str = "123";
            switch (str)
            {
              
            }
            #endregion

            #region 知识点四 可以自定义常量
            char c = 'A';
            const char c2 = 'a';//声明常量
            switch (c)
            {
                case c2:
                    Console.WriteLine("c=c2");
                    break;
                default:
                    break;
            }
            #endregion

            #region 知识点五 贯穿
            // 作用:满足某些条件时 做的事情是一样的 就可以使用贯穿
            int aa = 1;
            switch (aa)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("是个数字");
                   
                    break;
                default:
                    Console.WriteLine("不是个数字");
                    break;
            }
            #endregion

        }
    }
}
