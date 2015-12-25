using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;
using SeqQueueClass;
using LinkQueueClass;
using ListInterface;

namespace QueueTest
{
    class Program
    {
        // 用户号码变量
        static int number = 0;
        static object obj = new Object();
        static Thread thread2;
        static Thread thread3;
        // 存储队列
        static IQueue<int> list;
        static void Main(string[] args)
        {
            Console.WriteLine("请选择存储结构的类型：1.顺序队列 2.链队列");
            int type = Convert.ToInt32(Console.ReadLine());
            if (type == 1) 
            {
                list = new SeqQueue<int>(50);
            }
            else if (type == 2)
            {
                list = new LinkQueue<int>();
            }
            else 
            {
                Console.WriteLine("类型选择有误,默认为链队列存储");
                list = new LinkQueue<int>();
            }
            Console.WriteLine("请点击触摸屏获取号码:");
            Thread thread1 = new Thread(provideNumber);
            thread2 = new Thread(provideServiceWindowOne);
            thread3 = new Thread(provideServiceWindowTwo);
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
        // 提供服务到窗口2
        static void provideServiceWindowTwo()
        {
            while(true)
            {
                if (!list.IsEmpty()) 
                {
                    lock(thread3)
                    {
                        int number = list.QueueFront;
                        list.DeQueue();
                        Console.WriteLine("请{0}号到2号窗口", number);
                        Thread.Sleep(2000);
                    }     
                }
            }
        }
        // 提供服务到窗口1
        static void provideServiceWindowOne() 
        {
            while (true)
            {
                Thread.Sleep(2000);
                if (!list.IsEmpty())
                {
                    lock(thread2) 
                    {
                        int number = list.QueueFront;
                        list.DeQueue();
                        Console.WriteLine("请{0}号到1号窗口", number);
                    }
                }
            }
        }
        // 提供号码线程
        static void provideNumber() 
        {
            Console.ReadKey();
            number++;
            Console.WriteLine();
            Console.WriteLine("您的号码是{0},前面还有{1}位", number, list.Length);
            list.EnQueue(number);
            Console.WriteLine("请点击触摸屏获取号码:");
            Console.WriteLine();            
            Thread thread1 = new Thread(provideNumber);
            thread1.Start();
        }
    }
}
