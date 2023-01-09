using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 文字游戏
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("按下0开始游戏\n该游戏结局共计");
            int kaishi = Convert.ToInt32(Console.ReadLine());
            if (kaishi == 0)
            {
                Console.WriteLine("游戏开始.......");
                Console.WriteLine("睁开眼周围环境陌生，脑袋昏昏沉沉\n");
                Console.WriteLine("1.开门冲出去康康这个世界\t2.我穿越了？啪啪给自己两巴掌，这肯定是梦\t3.环顾四周\t4.谁扰我清梦，接着睡");
                int x1 = Convert.ToInt32(Console.ReadLine());
                switch (x1)
                {
                    case 1:
                        Console.WriteLine("你二话不说就冲了出去");
                        Console.WriteLine("1.左转\t2.右转下楼\t3.直接翻过前面的栏杆，跑出去\n");
                        int x2 = Convert.ToInt32(Console.ReadLine());
                        if (x2 == 1)
                        {
                            Console.WriteLine("你向左走，发现这是一栋宿舍楼，但是一个人都没看到。没走几步，你发现一扇寝室门上满是血，里面满是恶臭味，你");
                            Console.WriteLine("1.害怕，先跑为妙\n2.进去看看");
                            int w1 = Convert.ToInt32(Console.ReadLine());
                            if(w1==1)
                            {
                                Console.WriteLine("你感到十分害怕，从左边的楼梯下了楼。发现自己没带手机\n你打算先去 ");
                                Console.WriteLine("1.食堂  2.教学楼  3.找校门出去");
                                int w2 = Convert.ToInt32(Console.ReadLine());
                               if(w2==1)
                                {
                                    Console.WriteLine("你打算去食堂，发现不识路，瞎转半天，跑到了教学楼");
                                }
                               if(w2==2)
                                {
                                    Console.WriteLine("你跑到了教学楼（这是目及最高建筑）");
                                }
                            }
                            if (w1 == 2)
                            {
                                Console.WriteLine("你开门走了进去，发现地上都是残肢断臂，满墙都是血，你马上发现了事情的不对，忍着呕吐把地上的菜刀拿在手上才出去,你走下了楼，打算");
                                Console.WriteLine("1.食堂  2.教学楼  3.找校门出去");
                                int w3 = Convert.ToInt32(Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine("输入错误");
                            }
                               
                        }
                        else if (x2 == 2)
                        {
                            Console.WriteLine("");
                        }
                        else if (x2 == 3)
                        {
                            Console.WriteLine("你一个起跳，翻过了前面的栏杆，由于你的判断失误，你直接从8楼跳了下去\n");
                            Console.WriteLine("砰的一声，你摔死了......\n解锁结局2：跳楼");
                        }
                        break;
                    case 2:
                        Console.WriteLine("你二话不说抽了自己两巴掌“啪啪”两声，你两眼一黑\n死了......\n解锁结局1：把自己抽死");
                        break;
                    case 3:
                        Console.WriteLine("你看向四周，发现身处一个寝室内。里面有四张床\n");
                        Console.WriteLine("1.随便搜索寝室\t2.别人的东西还是不要乱动，离开寝室\t3.翻箱倒柜细细搜索寝室\n");
                        int x3 = Convert.ToInt32(Console.ReadLine());
                        if(x3==1)
                        {
                            Console.WriteLine("你潦草的搜索了寝室......\n发现农夫山泉x1    可口可乐x1  一副羽毛球拍x1\n");
                        }
                        else if(x3==2)
                        {
                            Console.WriteLine("不知道谁的寝室，还是先出去吧\n");
                        }
                        else if (x3 == 3)
                        {
                            Console.WriteLine("你仔仔细细的把寝室搜索了一遍\n");
                            Console.WriteLine("发现物品：农夫山泉x2  可口可乐x1 羽毛球拍x1  一根空心钢管x1 不知道多少电的电击枪x1 烧烤炉x1 一袋熟鸡柳x1 一袋混凝土x1 打火机x3 香烟x2\n");
                            Console.WriteLine("东西太多了，你决定拿一部分");
                            Console.WriteLine("方案1.农夫山泉  可口可乐 羽毛球拍 电击枪\n方案2.空心钢管  农夫山泉  电击枪\n方案3. 烧烤炉  一袋熟鸡柳  一袋混凝土  打火机  香烟\n");
                            int q1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("你选择了方案：");
                            if(q1==1)
                            {
                                Console.WriteLine("");
                            }
                            else if(q1==2)
                            {

                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("你眼皮都不带抬一下的，倒头就睡......");
                        break;
                }
            }
            Console.ReadKey();
        }
            
    }
}
