using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class 数组
    {
        static void Main(string[] args)
        {
            //方法1
            int[] a = {1,2,3,4,5,6,7,00,99 };//数据类型【】名称={}

            //方法2
            int[] c;
            c = new int[] { };
            //方法3
            int[] d;
            d = new int[5] {0,1,2,3,4 };

            a[2] = 9;



            //索引数组
            //for(int i=0;i<7;i++)//声明i判断小于7，判断一次输出一次，且自增1
            //{
            //    Console.Write(a[i]+" ");//索引数组数字输出后加一个空格
            //}
            //Console.WriteLine(a[2]);


            //int i = 0;
            //while(i<7)
            //{
            //    Console.Write(a[i]);
            //    i++;
            //}

            //foreach
            //foreach(int o in a)//创建一个临时变量存放数组
            //{
            //    Console.Write(o+" ");
            //}

            //获取数组的长度
            Console.Write(a.Length);
            for (int i = 0; i < a.Length; i++)//声明i判断小于数组长度，判断一次输出一次，且自增1
            {
                Console.Write(a[i] + " ");//索引数组数字输出后加一个空格
            }
            Console.WriteLine(a[2]);
            Console.ReadKey();
        }
    }
}
