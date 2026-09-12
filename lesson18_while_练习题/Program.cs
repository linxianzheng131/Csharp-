using System.Xml.Linq;

namespace lesson18_while_练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region 练习题一 求质数

            //while (true)
            //{
            //    try
            //    {

            //        int i = 2;
            //        while (true)
            //        {
            //            Console.WriteLine("请输入一个数字");
            //            int num = int.Parse(Console.ReadLine());
            //            while (num % i != 0 && i < num)
            //            {
            //                ++i;
            //            }
            //            Console.WriteLine(i < num ? "该数非质数" : "该数为质数");

            //        }

            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入的不是数字");
            //    }
            //}
            #endregion

            #region 练习题二 输密码
            //要求输入用户名和密码(admin/8888),用户名或者密码错误
            //则提示“用户名或密码错误”,直到输入正确为止
            //string name="";
            //int Key = 1;
            //bool bo = false;
            //while (true)
            //{
            //    try
            //    {
            //        while (name != "lin" || Key != 888) 
            //        {
            //            if (bo)
            //            {
            //                Console.WriteLine("false");
            //            }


            //            Console.WriteLine("请输入用户名");
            //            name = Console.ReadLine();
            //            Console.WriteLine("请输入密码");
            //            Key = int.Parse(Console.ReadLine());

            //            bo = true;
            //        }
            //    }
            //    catch 
            //    {
            //        Console.WriteLine("输入不合法");
            //    }
            //    if (name == "lin" && Key == 888)
            //    {
            //        break;
            //    }
            //}
            #endregion

            #region 练习题三 求ave
            //输入班级人数,然后依次输入学员成绩(需提示当前是第几个学员),
            //计算班级学员的平均成绩和总成绩。
            //Console.WriteLine("请输入班级人数");
            //int num = int.Parse(Console.ReadLine());
            //int index = 0;
            //int sum = 0;
            //int ave;
            //try
            //{
            //    while (index < num)
            //    {
            //        ++index;
            //        Console.WriteLine("这是第{0}个成员", index);
            //        Console.WriteLine("请输入该成员的成绩");
            //        int result = int.Parse(Console.ReadLine());
            //        sum += result;
            //    }

            //    Console.WriteLine("总成绩为{0}，平均成绩为{1}", sum, sum / index);

            //}
            //catch
            //{
            //    Console.WriteLine("false");
            //}
            #endregion

            #region 练习题四 求数列
            //求数列1,1,2,3,5,8,13 .... 的第20位数字是多少?
            Console.WriteLine("请输入你想求该数列第几位数");
            int index = 0;
            int n1 = 1;
            int n2 = 1;
            int result=0;
            try
            {
                int need = int.Parse(Console.ReadLine());

                while (index < need)
                {
                    index++;
                    if (index == 1)
                    {
                        result = n1;
                    }
                    else if (index == 2)
                    {
                        result = n2;
                    }
                    else
                    {
                        
                        result= n1 + n2;
                        n1 = n2;
                        n2 = result;
                       
                    }
                }
                Console.Write("第{0}位数是", index );
                Console.Write(result);
            }
            catch
            {
                Console.WriteLine("false");
            }
            #endregion
        }
    }
}
