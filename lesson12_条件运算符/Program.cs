namespace lesson12_条件运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 条件运算符
            Console.WriteLine("条件运算符");
            //用于比较两个变量或常量
            //是否大于>
            //是否小于<
            //是否等于==
            //是否不等于!=
            //是否大于等于>=
            //是否小于等于<=

            //条件运算符 一定存在左右两边的内容
            //左边内容 条件运算符 右边内容
            int a = 5;
            int b=10;
            //条件运算符 不能直接这样使用
            //单纯比较不用结果 那么对于我们来说 没有任何意义
            //比较的结果 返回的是 一个bool 类型的值 
            //true和false 如果比较的条件满足 那就返回true 不满足 就返回false
            //先算右边 再赋值给左边
            bool result = a > b;
            Console.WriteLine(result);

            result = a < b;
            Console.WriteLine(result);
            #endregion

            #region 知识点二 各种应用写法
            //变量和变量比较
            a = 5;
            b = 10;
            result= a < b;
            //变量和数值(常量)比较
            result = a > 3;
            //数值和数值比较
            result = 3>2;
            //计算结果比较
            //条件运算符 优先级 低于算术运算符
            //7>6
            //先计算 再比较
            result = a + 2 > a - 2 + 3;
            #endregion

            #region 知识点三 不能进行范围比较

            a = 5;
            //判断是否在两个值之间
            //1<a<6
            //在C#不能这样写
            //要判断 一个变量是否在 两个数之间 要结合 逻辑运算符的知识点

            #endregion

            #region 知识点四 不同类型之间的比较

            //不同数值类型之间 可以随意进行条件运算符比较
            int i = 2;
            float f = 1.2f;
            uint ui = 222;
            result = i > f;
            result i = ui > i;

            //特殊类型 char string bool 只能 同 类型进行 == 和 != 比较
            string str = "123";
            char c = 's';
            bool bo = true;
            result = str == "234";
            result = bo != true;

            //char 不仅可以和自己类型进行==!= 还可以和数值类型进行比较
            //还可以和 字符类型进行大小比较

            result = c > 123;
            result = c > '2';

            #endregion
        }
    }
}
