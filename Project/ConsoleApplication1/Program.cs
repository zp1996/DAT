using System;
using System.Collections.Generic;
using System.Text;
using ListInterface;
using DArrayClass;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 线性表客户端测试
            //LinearList<int> arr = new LinearList<int>(5);
            //int j = 0;
            //for (int i = 2; i <= 100; i++)
            //{
            //    if (i % 5 == 0 || i % 7 == 0)
            //    {
            //        arr.Insert(j++, i);
            //    }
            //}
            //int len = arr.Length;
            //for (int i = 0; i < len; i++) 
            //{
            //    Console.WriteLine("{0}",arr[i]);
            //}

            // 线性表练习—学生成绩
            //LinearList<StudentData> list = new LinearList<StudentData>(5);
            //StudentData stu1 = new StudentData(106, "李国煌", 76);
            //StudentData stu2 = new StudentData(107, "刘正", 90);
            //StudentData stu3 = new StudentData(108, "刘羽", 80);
            //list.Insert(0,stu1);
            //int index = FindIndex(stu2, list);
            //list.Insert(index,stu2);
            //int index1 = FindIndex(stu3, list);
            //list.Insert(index1,stu3);
            //Console.WriteLine("{0}",list[0]);
            //Console.WriteLine("{0}", list[1]); 
            //Console.WriteLine("{0}", list[2]);
            
            // 单链表客户端测试
            //SLinkList<int> list = new SLinkList<int>();
            //list.Insert(0, 4);
            //list.Insert(0, 3);
            //list.InsertAtFirst(2);
            //list.InsertAtEnd(5);
            //Console.WriteLine(list.ToString());
            //list.reverse();
            //SLinkList<int> cloneList = list.clone();
            //Console.WriteLine(cloneList.ToString());
            //Console.WriteLine(list.ToString());

            // 循环列表客户端测试
            //CLinkList<int> list = new CLinkList<int>();
            //list.Insert(0, 4);
            //list.Insert(0, 3);
            //list.InsertAtFirst(2);
            //list.InsertAtEnd(5);
            //Console.WriteLine(list.Length);
            //Console.WriteLine(list[3].Data);
            //Console.WriteLine(list.ToString());
        
            // C#没有js那样的执行上下文,而且C#必须在声明变量后,赋值才能
            // 使用啊
            //int i;
            //Console.WriteLine("{0}",i); // 使用了未赋值的局部变量i
            // 给数组开辟了内存的话,不进行赋值会是神马?
            //int[] array = new int[10];
            //Console.WriteLine("{0}", array[0]);
            // int类型的默认是0啊

            // 动态数组客户端测试
            //DArray<int> array = new DArray<int>(1);
            //array[0] = 20;
            //array.ReSize(2);
            //array[1] = 30;
            //Console.WriteLine("{0}",array[1]);
            // 动态数组练习:编写一段代码,要求输入一个整数N,用动态数组
            // A存放2~N之间所有5或7的倍数,输出该数组
            //Console.WriteLine("请输入一个正整数N");
            //string input = Console.ReadLine();
            //int N = Convert.ToInt32(input);
            //DArray<int> A = new DArray<int>(1);
            //int j = 0;
            //for (int i = 2; i <= N; i++)
            //{
            //    if (i % 5 == 0 || i % 7 == 0)
            //    {
            //        if (j == A.Size - 1) A.ReSize(A.Size + 10);
            //        A[j++] = i;
            //    }
            //}
            //for (int i = 0; i < A.Size; i++)
            //{
            //    if (A[i] == 0) break;
            //    Console.Write("{0}\t", A[i]);
            //}
            // 稀疏矩阵客户端测试
            //IMatrix test = new Matrix(2, 1);
            //IMatrix testA = new Matrix(2, 1);
            //test[0, 0] = 20;
            //testA[0, 0] = 20;
            ////Console.WriteLine(test);
            ////Console.WriteLine(testA);
            //IMatrix testAdd = (Matrix)test.Add((Matrix)testA);
            //Console.WriteLine(testAdd);

            // 顺序栈客户端测试
            //IStack<string> stack = new SeqStack<string>(500);
            //stack.Push("a1");
            //stack.Push("a2");
            //stack.Pop();
            //Console.WriteLine("{0}", stack.StackTop);
            //Console.WriteLine("{0}", stack.Length);

            // 链栈客户端测试
            //IStack<string> stack = new LinkStack<string>();
            //stack.Push("a1");
            //stack.Push("a2");
            //Console.WriteLine("{0}", stack.StackTop);
            //Console.WriteLine("{0}", stack.Length);

            // 顺序队列客户端测试
            //IQueue<int> list = new SeqQueue<int>(20);
            //list.EnQueue(10);
            //list.EnQueue(20);
            //list.EnQueue(30);
            //list.EnQueue(40);
            //list.EnQueue(50);
            //list.DeQueue();
            //Console.WriteLine("{0}", list.QueueFront);
            //Console.WriteLine("{0}", list.Length);

            // 顺序循环队列客户端测试
            //IQueue<int> list = new CSeqQueue<int>(20);
            //list.EnQueue(10);
            //list.EnQueue(20);
            //list.EnQueue(30);
            //list.EnQueue(40);
            //list.EnQueue(50);
            //list.DeQueue();
            //Console.WriteLine("{0}", list.QueueFront);
            //Console.WriteLine("{0}", list.Length);

            // 链式队列客户端测试
            //IQueue<int> list = new LinkQueue<int>();
            //list.EnQueue(10);
            //list.EnQueue(20);
            //list.EnQueue(30);
            //list.EnQueue(40);
            //list.EnQueue(50);
            //list.DeQueue();
            //Console.WriteLine("{0}", list.QueueFront);
            //Console.WriteLine("{0}", list.Length);

            // 串客户端测试
            //IString str = new SeqString("defretr");
            //Console.WriteLine("{0}", str.Replace("r", "zp", 0).ToString());
            //Console.WriteLine("{0}", str.paddingLeft(9, "a").ToString());
            //IString str1 = new SeqString("abc");
            //IString str2 = str.Insert(1, str1);
            //IString str3 = str2.Remove(2, 5);
            //Console.WriteLine("{0}", str2.ToString());
            //Console.WriteLine("{0}", str2.Length);
            //Console.WriteLine("{0}", str3.ToString());
            //Console.WriteLine("{0}", str2.concat(str3).ToString());

            // 数客户端测试
            //IntSet a = new IntSet(10);
            //IntSet b = new IntSet(10);
            //a.Insert(5);
            //a.Insert(6);
            //Console.WriteLine("{0}", a.Union(b).GetBitString());
            //Console.WriteLine("{0}", a.Intersect(b).GetBitString());
            //Console.WriteLine("{0}", a.IsSubSet(b));

            // 二叉树客户端测试
            //BinTreeNode<string> A = new BinTreeNode<string>("A");
            //BinTreeNode<string> B = new BinTreeNode<string>("B");
            //BinTreeNode<string> C = new BinTreeNode<string>("C");
            //BinTreeNode<string> D = new BinTreeNode<string>("D");
            //BinTree<string> tree = new BinTree<string>(A);
            //tree.Insert(A, B, C);
            //tree.Insert(B, D, null);
            //Console.WriteLine("先序遍历:" + tree.PreOrderTraversal());
            //Console.WriteLine("中序遍历:" + tree.MidOrderTraversal());
            //Console.WriteLine("后序遍历:" + tree.PostOrderTraversal());
            //Console.WriteLine("层次遍历:" + tree.LevelTraversal());
            //BinTreeNode<string> parent = tree.GetParent(D);
            //Console.WriteLine("节点{0}的parent是节点{1}", D.Data, parent.Data);    
        }
    }
}
