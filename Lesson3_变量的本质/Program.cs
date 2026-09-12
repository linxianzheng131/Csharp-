namespace Lesson3_变量的本质
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("变量的本质");
            #region 知识点一 变量的存储空间（内存中）
            // 1byte=8bit
            //1kb=1024byte
            //1mb=1024kb
            //1gb=1024g
            //通过sizeof方法 可以获取变量类型所占的内存空间（单位:字节）
            //有符号
            int sbyteSize = sizeof(sbyte);
            Console.WriteLine("sbyte所占的字节数为：" + sbyteSize);
            int intSize = sizeof(int);
            Console.WriteLine("int所占的字节数为：" + intSize);
            int shortSize = sizeof(short);
            Console.WriteLine("short所占的字节为；" + shortSize);
            int longSize = sizeof(long);
            Console.WriteLine("long所占的字节为；" + longSize);
            Console.WriteLine("******************************************");
            //无符号
            int byteSize = sizeof(byte);
            Console.WriteLine("byte所占的字节数为：" + byteSize);
            int uintSize = sizeof(uint);
            Console.WriteLine("uint所占的字节数为：" + uintSize);
            int ushortSize = sizeof(ushort);
            Console.WriteLine("ishort所占的字节为；" + ushortSize);
            int ulongSize = sizeof(ulong);
            Console.WriteLine("ilong所占的字节为；" + ulongSize);
            Console.WriteLine("******************************************");
            //浮点数
            int floatSize = sizeof(float);
            Console.WriteLine("float所占的字节数为：" + floatSize);
            int doubleSize = sizeof(double);
            Console.WriteLine("double所占的字节数为：" + doubleSize);
            int decimalSize = sizeof(decimal);
            Console.WriteLine("decimal所占的字节为；" + decimalSize);
            Console.WriteLine("******************************************");
            //特殊类型
            int boolSize = sizeof(bool);
            Console.WriteLine("bool所占的字节数为："+boolSize);
            int charSize = sizeof(char);
            Console.WriteLine("char所占的字节数为："+charSize);

            //sizeof时不能得到string类型所占的内存大小的
            //因为字符窜大小长度时可变的 不定的
            //int stringSize = sizeof(string);
         
            #endregion


            #region 知识点二 变量的本质
            //本质都是0和1
            //1byte=8bit（0000 0000）
            #endregion



        }
    }
}
