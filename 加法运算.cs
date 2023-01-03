using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入数字进行加法操作");
            int a = Convert.ToInt32(Console.ReadLine());//把输入的字符转换为int类型的整数
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
