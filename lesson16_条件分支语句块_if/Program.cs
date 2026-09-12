namespace lesson16_条件分支语句块_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("if语句");

            #region 知识点一 作用
            //让顺序执行的代码 产生分支
            //if语句是第一个 可以让我们的程序 产生逻辑变化的 语句
            #endregion

            #region 知识点二 if语句
            // 作用:满足条件时 多执行一些代码
            //语法:
            // if(boo1类型值)//boo1类型相关:boo1变量 条件运算符表达式 逻辑运算符表达式
            //{
            //   满足条件要执行的代码 写在if代码块中;
            //}
            // 注意:
            // 1.if语句的语法部分，不需要写分号
            // 2.if语句可以嵌套使用
            if (3 > 5)
            {
                Console.WriteLine("这个是if语句");
            }

            int rightpassWord = (666);
            string rightname = ("linxianzheng");
            //嵌套使用
            Console.WriteLine("请用户输入用户名");
            string name = Console.ReadLine();


            if (name == rightname)
            {
                Console.WriteLine("用户名输入正确");
                Console.WriteLine("请用户输入密码");
                try
                {
                    string passWord_ = Console.ReadLine();
                    int passWord = int.Parse(passWord_);

                    if (passWord == rightpassWord)
                    {
                        Console.WriteLine("密码输入正确");
                    }
                }
                catch
                {
                    Console.WriteLine("输入内容不合法");
                }
            }
            #endregion

            #region 知识点三 if  else语句
            //作用:产生两条分支 十字路 满足条件做什么 不满足条件做什么
            //语法：
            //if( bool 类型值)
            //{
            //  满足条件执行的代码
            //}
            //else
            //{
            //  不满足条件执行的代码
            //}
            //注意：
            //.if...else 语句 语法部分 不需要写分号
            ///if...else 语句 可以嵌套
            #endregion

            #region 知识点四 if…else if…else语句
            //作用：产生n条分支 多条道路选择 最先满足其中的一个条件 就做哪一个
            //if( bool 类型值)
            //{
            //  满足条件执行的代码
            //}
            //else if（bool类型值）
            //{
            //  满足条件执行的代码
            //}
            //...中间可以有n个 else if语句代码块
            //else
            //{
            //  不满足条件执行的代码
            //}
            // 注意:
            //1.和前面两个是一样的 不需要写分号
            //2.可以嵌套
            //3.else  可以看成是补充 可以省略
            //4.注意 条件判断 从上到下执行 满足了第一个后 之后的都不会执行了
            #endregion
        }
    }
}
