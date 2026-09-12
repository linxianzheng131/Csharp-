namespace lesson19_do_while__练习题
{
    internal class Program
    {
        static void Main(string[] args)
        //输入名字和密码后，提示是否正确
        {
           
            
                string name;
                try
                {
                    int Key;
                    bool bo = false;
                    do
                    {
                        if (bo)
                        {
                            Console.WriteLine("false");
                        }


                        Console.WriteLine("请输入用户名");
                        name = Console.ReadLine();
                        Console.WriteLine("请输入密码");
                        Key = int.Parse(Console.ReadLine());

                        bo = true;

                        if(name == "lin" && Key == 888)
                        {
                            break;
                        }
                    } while (name != "lin" || Key != 888);
                }
                catch
                {
                    Console.WriteLine("输入不合法");
                }

            
           
            
        }
    }
}
