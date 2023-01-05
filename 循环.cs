using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine();
            //int i = Convert.ToInt32(Console.ReadLine());
            //while(i<20)
            //{
            //    i++;
            //    Console.WriteLine(i);
            //}


            //Console.WriteLine();
            //for (int i = 1; i <= 100; i++)//判断；条件；输出
            //{
            //    Console.Write(i);//输出不换行
            //}


            //int i = Convert.ToInt32(Console.ReadLine());
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i<10);


            for(int i=1;i<=100;i++)
            {
                if(i%2==0)
                {
                    continue;//判断i被2取余后等于0则跳过这次循环
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
