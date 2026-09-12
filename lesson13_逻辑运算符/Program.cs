namespace lesson13_逻辑运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("逻辑运算符");
            //对bool类型 进行逻辑运算

            #region 知识点一 逻辑与
            //符号 &&
            //规则 对两个bool值进行逻辑运算 有假则假 同真则真

            bool result = true && false ;
            Console.WriteLine(result);//false
            result = true && true&&true&&true;
            Console.WriteLine(result);//true

            //bool 相关的类型bool变量 条件运算符
            //逻辑运算符优先级 低于 条件运算符 算术运算符
            //false&&false&&true
            result = 3 > 4 && 2 > 3&&7==7;
            Console.WriteLine(result);

            int i = 3;
            //
            result = i > 1 && i< 4;
            Console.WriteLine(result);

            //多个逻辑与 组合运用
            //在没有括号的情况下 从左到右 依次看即可
            //有括号 先看括号内

            #endregion

            #region 知识点二 逻辑或
            //符号 ||
            //规则 对两个bool值进行 逻辑运算 有真则真 同假则假
            result = true || false || false || false ;
            Console.WriteLine(result);
            result = false||false || false ;
            Console.WriteLine(result);
            //其他同理
            #endregion

            #region 知识点三 逻辑非
            //符号 ！
            //规则 对一个bool值进行取反 真变假 假变真

            result = !true;
            Console.WriteLine(result);
            result = !false;
            Console.WriteLine(result);

            result = !!true;
            Console.WriteLine(result);
            //逻辑非的 优先级 较高 要加括号
            result = !(3>2);
            Console.WriteLine(result);
            #endregion

            #region 知识点四 混合使用优先级问题
            //规则 ！优先级最高 &&优先级高于||
            //逻辑运算符优先级 低于 算术运算符 条件运算符（逻辑非除外）

            bool gameOver = false;
            int hp = 10;
            bool isDead = false;
            bool isMustOver = true;
            //false||false&&true||true
            result = gameOver || hp < 0 && !isDead || isMustOver;
            Console.WriteLine(result);
            #endregion

            #region 知识点五 逻辑运算符短路规则

            int i2 = 1;
            //只要 逻辑与或者逻辑或 左边满足了条件
            //只要 满足条件 右边的内容 对于我们来说 已经不重要

            //逻辑或 有真为真 那左边只要为真了 右边就不重要了
            //true||i2++>1;抛弃后面不去计算
            result = i2 > 0 || ++i2 >= 1;
            Console.WriteLine(i2);//答案是1 不是2
            Console.WriteLine(result);

            //逻辑与 有假为假 那左边只要为假了 右边就不重要了
            //false&&i2++>1;抛弃后面不去计算
            result = i2 < 0 && i2++ > 1;
            Console.WriteLine(i2);//答案是1 不是2
            Console.WriteLine(result);

            result = i2++ > 1 && i2 < 0;
            Console.WriteLine(i2);//答案是2
            Console.WriteLine(result);
            #endregion

        }
    }
}
