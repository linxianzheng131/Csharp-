namespace lesson19_循环语句_do_while语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("do while循环");

            #region 知识点一 基本语法
            //while循环 是先判断条件再执行
            // do while循环 是先斩后奏 先至少执行一次循环语句块中的逻辑 再判断是否继续
            //do
            //{
            //do while 循环语句块;
            //} while (bool类型的值);
            // 注意 do while 语句 存在一个重要的分号
            #endregion

            #region 知识点二 实际使用
            //使用较少
            do
            {
                Console.WriteLine("do while 循环语句块");
            } while (true);
            #endregion

            #region 知识点三 嵌套使用
            //同之前循环一样
            //break continue也可以用 但是continue是回到while 也就是不回do 而是会判断
            #endregion


        }
    }
}
