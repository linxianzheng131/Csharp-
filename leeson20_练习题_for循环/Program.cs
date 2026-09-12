using System.Text.Json.Serialization;

namespace leeson20_练习题_for循环
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for循环");
            #region 练习题一 水仙花
            //找出100~999之间的水仙花数
            //例如：153 = 1 * 1 * 1 + 5 * 5 * 5 + 3 * 3 * 3 这个数就是水仙花数
            int hun;
            int ten;
            int unit;
            for (int i=100;i<1000;++i)
            {
                hun = i / 100;
                ten = (i % 100)/10;
                unit = i % 10;
                if(hun*hun*hun+ten*ten*ten+unit*unit*unit==i)
                {
                    Console.WriteLine(i);
                }

            }
            #endregion

            #region 练习题二 99乘法表
            for(int i=1;i<10;++i)
            {
                for(int j=1;j<=i;++j)
                {
                    Console.Write("{0}*{1}={2}  ", j, i, i * j);
                   
                }
                Console.WriteLine("");
            }
            #endregion

            #region 练习题三 列方阵
            for(int i=1;i<=10;++i)
            {
                if ( i == 1 || i == 10)
                {
                    for(int j=1;j<=10;++j)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int j = 1; j <= 10; ++j)
                    {
                        if (j == 1||j==10)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine("");
            }
            #endregion

            #region 练习题四 列三角阵
            for(int i=1;i<=10;++i)
            {
                for(int j=1;j<=2*i-1;++j)
                {
                    if (j <= 2 * i - 1)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine("");
            }
            for (int i = 1; i <= 10; i++)
            {
                for(int k=1;k<11-i;++k)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }


            #endregion
        }
    }
}
