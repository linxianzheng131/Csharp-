namespace Lesson6_转义字符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("转义字符");

            #region 知识点一 转义字符的使用
            //转义字符是字符串的一部分用来表示一些特殊含义的字符
            //比如：在字符串中表现 单引号 引号 空行等等
            string str = "";

            #region 固定写法
            //固定写法：\字符
            //不同的 \和字符的人组合 表示不同的含义

            //常用转义字符
            //单引号\'
            string str1 = "\'666\'";
            Console.WriteLine(str1);
            //双引号\"
            string str2 = "\"666\"";
            Console.WriteLine(str2);
            //换行\n
            string str3 = "1234\n1234\n1234\n1234\n1234";
            Console.WriteLine(str3);
            //斜杠\\
            string str4 = "\\666\\";
            Console.WriteLine(str4);

            //不常用转义字符
            //制表符（TAB）\t
            string str5 = "\t666\t";
            Console.WriteLine(str5);
            //光标退格\b
            string str6 = "123\b123";
            Console.WriteLine(str6);
            //警报音\a
            string str7 = "\a";
            Console.WriteLine(str7);
            //空字符\0
            string str8= "\06\06\06\0";
            Console.WriteLine(str8);


            #endregion


            #endregion

            #region 知识点二 取消转义字符
            //用@就行
            string str9 = @"\666\";
            Console.WriteLine(str9);
            Console.WriteLine(@"''");
            #endregion

            #region 练习题一 

            #endregion

            #region 练习题二

            #endregion


        }
    }
}
