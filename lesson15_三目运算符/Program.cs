namespace lesson15_三目运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("三木运算符");
            //套路: 3个空位 2个符号!!
            //固定语法:空位    ?空位  :  空位;
            //关键信息:boo1类型 ?boo1类型为真返回内容 : boo1类型为假返回内容
            //三日运算符 会有返回值，这个返回值类型必须一致，并且必须使用!

            string str = false ? "条件为真" : "条件为假";
            Console.WriteLine(str);

            int a = 5;
            str = a < 1 ? "a小于1" : "a大于1"; 
            Console.WriteLine(str);

            //第一个空位 始终是结果为bool类型的表达式 bool变量 条件表达式 逻辑运算符表达式
            //第三个空位 什么表达式都可以 只要保证他们的结果类型是一致的
        }
    }
}
