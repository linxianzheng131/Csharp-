namespace Lesson15_三目运算符_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region 练习题1
            //比较两个数字的大小 打印出最大值
            Console.WriteLine("请玩家输入数字");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("请玩家输入数字");
            int b = int.Parse(Console.ReadLine());
            int c = a < b ? b : a;
            Console.WriteLine(c);

            #endregion

        }
    }
}
