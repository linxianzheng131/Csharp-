namespace Leasson10_算术运算符_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("算术运算符");

            //算数运算符 是用于 数值类型计算的运算符
            //它的返回结果是数值

            #region 知识点一 赋值符号

            // =
            // 关键知识点：
            //先看右侧 在看左侧 把右侧的值赋值给左侧的变量

            #endregion

            #region 知识点二 算术运算符

            #region 加 +
            //用自己计算 先算右侧结果 再赋值给左侧变量
            int i = 1;

            i = i + 4;
            //连续运算 先算右侧结果 再赋值给左侧变量
            i = i + 8 + 8+9;
            //初始化时就运算 先算右侧结果 再赋值给左侧变量
            int i2 = 1 + 9 + 6 + i;
            #endregion

            #region 减 -
            //同加号
            #endregion

            #region 乘 *
            //同上
            #endregion

            #region 除 /
            //规则同上

            //默认的整数是int 如果用来做除法运算 要注意 会丢失小数点 
            //如果你想用浮点数来存储 一定是 在运算时要要有浮点数的特征 如f m
            float f = 1 / 2;
            //输出结果会是0
            Console.WriteLine(f);
            #endregion

            #region 取余 %

            //运算规则同上

            //余数的运算规则 4%2就是4/2的余数
            int i3 = 10;
            i3 = i3 % 4;
            //结果为2
            Console.WriteLine(i3);
            i3 = 9 % 2 % 2;
            //结果为1
            Console.WriteLine(i3);

            #endregion

            #endregion

            #region 知识点三 算术运算符的 优先级
            //小学运算方法
            //先乘除取余后加减 有括号先算括号
            //注意：程序运算没有用大括号和中括号 但是可以用多个小括号
            //有多个小括号先算里面
            #endregion

            #region 知识点四 算术运算符的 复合运算符
            //固定写法 运算符=
            //+= -= /= %=
            //复合运算 是用于 自己=自己进行运算
            int y = 1;
            y = y + 2;
            Console.WriteLine(y);

            y = 1;
            y += 2;//y=y+2
            Console.WriteLine(y);

            y = 2;
            y += 2;//4
            y -= 2;//2
            y /= 2;//1
            y *= 2;//2
            y %= 2;//0
            Console.WriteLine(y);
            int iu = 10;
            iu += 20 * 2 / 10;
            Console.WriteLine(iu);//14

            //注意：复合运算符 只能进行一种运算 不能混合运算
            //i4 */+-=2；

            #endregion

            #region 知识点五 算术运算符的 自增减
            int a2 = 1;
            a2 = a2 + 1;

            a2 = 1;
            a2 += 1;

            //自增运算符
            a2 = 1;
            a2++;//先用在加
            Console.WriteLine(a2);
            ++a2;//先加在用
            Console.WriteLine(a2);
            a2 = 1;
            Console.WriteLine(a2++);//1
            //2
            Console.WriteLine(++a2); //3

            //自减运算符
            a2 = 1;
            a2--;//先用在减
            Console.WriteLine(a2);
            --a2;//先减在用
            Console.WriteLine(a2);
            a2 = 1;
            Console.WriteLine(a2--);//1
            //0
            Console.WriteLine(--a2);//-1


            #endregion

        }
    }
}
