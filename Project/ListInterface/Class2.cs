using System;
using System.Collections.Generic;
using System.Text;

namespace ListInterface
{
    // 顺序表
    //public class LinearList<T> : ILinearList<T>
    //{
    //    #region 私有成员

    //    private int length;
    //    private DArray<T> list;
    //    private int maxSize;

    //    #endregion;

    //    #region ILinearList<T> 成员

    //    public LinearList(int max)
    //    {
    //        if (max < 0)
    //        {
    //            throw new Exception("顺序列表的长度要大于0");
    //        }
    //        this.maxSize = max;
    //        list = new DArray<T>(max);
    //    }
    //    public int MaxSize
    //    {
    //        get
    //        {
    //            return this.maxSize;
    //        }
    //    }
    //    public int Length
    //    {
    //        get
    //        {
    //            return this.length;
    //        }
    //    }

    //    public T this[int index]
    //    {
    //        get
    //        {
    //            if (index < 0 || index > this.length - 1)
    //            {
    //                throw new Exception("索引值的传入有错误");
    //            }
    //            return this.list[index];
    //        }
    //        set
    //        {
    //            if (index < 0 || index > this.length - 1) throw new Exception("索引值的传入有错误");
    //            this.list[index] = value;
    //        }
    //    }

    //    public bool IsEmpty()
    //    {
    //        return this.length == 0 ? true : false;
    //    }

    //    public void Insert(int index, T data)
    //    {
    //        if (index < 0)
    //        {
    //            throw new Exception("索引值传入有错误");
    //        }
    //        if (index >= this.length || this.length == this.maxSize)
    //        {
    //            list.ReSize(this.length + 10);
    //        }
    //        for (int i = this.length; i > index; i--)
    //        {
    //            list[i] = list[i - 1];
    //        }
    //        list[index] = data;
    //        this.length++;
    //    }

    //    public void Remove(int index)
    //    {
    //        if (index < 0 || index > this.length || this.length == this.maxSize)
    //        {
    //            throw new Exception("索引值传入有错误");
    //        }
    //        for (int i = index; i < this.length; i++)
    //        {
    //            list[i] = list[i + 1];
    //        }
    //        length--;
    //    }

    //    public int Search(T data)
    //    {
    //        for (int i = 0; i < this.length; i++)
    //        {
    //            if (list[i].Equals(data) == true)
    //            {
    //                return i;
    //            }
    //        }
    //        return -1;
    //    }

    //    public void Clear()
    //    {
    //        this.length = 0;
    //    }

    //    #endregion
    //}
    // 单链表
    //public class SLinkList<T> : ILinearList<T>
    //{
    //    protected SNode<T> pHead;
    //    protected int length;

    //    public int Length
    //    {
    //        get
    //        {
    //            return this.length;
    //        }
    //    }
    //    public T this[int index]
    //    {
    //        get
    //        {
    //            if (index < 0 || index > this.length - 1)
    //            {
    //                throw new Exception("索引值传入有错误");
    //            }
    //            return Locate(index).Data;
    //        }
    //        set
    //        {
    //            if (index < 0 || index > this.length - 1)
    //            {
    //                throw new Exception("索引值传入有错误");
    //            }
    //            Locate(index).Data  = value;
    //        }
    //    }
    //    public SLinkList()
    //    {
    //        this.length = 0;
    //        this.pHead = null;
    //    }
    //    protected SNode<T> Locate(int index)
    //    {
    //        if (index < 0 || index > this.length - 1)
    //        {
    //            throw new Exception("索引值传入有错误");
    //        }
    //        SNode<T> temp = this.pHead;
    //        for (int i = 0; i < index; i++)
    //        {
    //            temp = temp.Next;
    //        }
    //        return temp;
    //    }
    //    public void InsertAtFirst(T data)
    //    {
    //        SNode<T> node = new SNode<T>(data, this.pHead);
    //        this.pHead = node;
    //        this.length++;
    //    }
    //    public void InsertAtEnd(T data)
    //    {
    //        SNode<T> node = new SNode<T>(data);
    //        if (this.length == 0)
    //        {
    //            this.pHead = node;
    //        }
    //        else
    //        {
    //            Locate(this.length - 1).Next = node;
    //        }
    //        this.length++;
    //    }
    //    public void Insert(int index, T data)
    //    {
    //        if (index < 0 || index > this.length)
    //        {
    //            throw new Exception("索引值传入有错误");
    //        }
    //        if (index == 0)
    //        {
    //            InsertAtFirst(data);
    //        }
    //        else if (index == this.length)
    //        {
    //            InsertAtEnd(data);
    //        }
    //        else
    //        {
    //            SNode<T> node = new SNode<T>(data, Locate(index));
    //            Locate(index - 1).Next = node;
    //            this.length++;
    //        }
    //    }
    //    public void Remove(int index)
    //    {
    //        if (index < 0 || index > this.length)
    //        {
    //            throw new Exception("索引值输入有错误啊");
    //        }
    //        if (index == 0)
    //        {
    //            this.pHead = this.pHead.Next;
    //        }
    //        else
    //        {
    //            Locate(index - 1).Next = Locate(index).Next;
    //        }
    //        this.length--;
    //    }
    //    public int Search(T data)
    //    {
    //        SNode<T> temp = this.pHead;
    //        for (int i = 0; i < this.length; i++)
    //        {
    //            if (temp.Data.Equals(data) == true)
    //            {
    //                return i;
    //            }
    //            temp = temp.Next;
    //        }
    //        return -1;
    //    }
    //    public bool IsEmpty()
    //    {
    //        return this.length == 0 ? true : false;
    //    }
    //    public void Clear()
    //    {
    //        this.length = 0;
    //        this.pHead = null;
    //    }
    //    public override string ToString()
    //    {
    //        string str = "";
    //        SNode<T> temp = this.pHead;
    //        for (int i = 0; i < this.length; i++)
    //        {
    //            if (temp.Next == null)
    //            {
    //                str += temp.Data + "这是最后一个；";
    //            }
    //            else
    //            {
    //                str += temp.Data + "下一个的数据是:" + temp.Next.Data + "\n";
    //            }
    //            temp = temp.Next;
    //        }
    //        return str;
    //    }
    //    public SLinkList<T> clone()
    //    {
    //        SLinkList<T> List = new SLinkList<T>();
    //        SNode<T> newHead = null;
    //        SNode<T> temp = this.pHead;
    //        for (int i = 0; i < length; i++) 
    //        {
    //            if (newHead == null)
    //            {
    //                newHead = new SNode<T>(temp.Data);
    //                List.pHead = newHead;
    //            }
    //            else 
    //            {
    //                newHead.Next = new SNode<T>(temp.Data);
    //                newHead = newHead.Next;
    //            }
    //            temp = temp.Next;
    //        }
    //        List.length = this.length;
    //        return List;
    //    }
    //    public void reverse() 
    //    {
    //        SNode<T> temp = this.pHead;
    //        SNode<T> nextRaer = null;
    //        //for (int i = 0; i < this.length; i++) 
    //        //{
    //        //SNode<T> item = temp.Next;
    //        //temp.Next = nextRaer;
    //        //nextRaer = temp;
    //        //    if (item != null)
    //        //    {
    //        //        temp = item;
    //        //    }
    //        //}
    //        while (temp != null)
    //        {
    //            SNode<T> item = temp.Next;
    //            temp.Next = nextRaer;
    //            nextRaer = temp;
    //            temp = item;
    //        }
    //        this.pHead = nextRaer;
    //    }
    //}
    // 循环列表
    //public class CLinkList<T> : ILinearList<T>
    //{
    //    private int length;
    //    private SNode<T> pRear;
    //    public int Length
    //    {
    //        get
    //        {
    //            return this.length;
    //        }
    //    }
    //    public SNode<T> this[int index]
    //    {
    //        get 
    //        {
    //            if (index < 0 || index > this.length - 1) 
    //            {
    //                throw new Exception("索引值传入有错误");
    //            }
    //            return Locate(index);
    //        }
    //        set
    //        {
    //            if (index < 0 || index > this.length - 1)
    //            {
    //                throw new Exception("索引值传入有错误");
    //            }
    //            SNode<T> temp = Locate(index);
    //            temp = value;
    //        }
    //    }
    //    public CLinkList()
    //    {
    //        this.length = 0;
    //        this.pRear = null; 
    //    }
    //    private SNode<T> Locate(int index) 
    //    {
    //        if (index < 0 || index > this.length - 1) 
    //        {
    //            throw new Exception("索引值有错误");
    //        }
    //        SNode<T> temp = this.pRear.Next;
    //        for (int i = 0; i < index; i++)
    //        {
    //            temp = temp.Next;
    //        }
    //        return temp;
    //    }
    //    public void InsertAtFirst(T data) 
    //    {
    //        SNode<T> node = null;
    //        if (this.length == 0)
    //        {
    //            node = new SNode<T>(data, null);
    //            node.Next = node;
    //            this.pRear = node;
    //        }
    //        else 
    //        {
    //            node = new SNode<T>(data, this.pRear.Next);
    //        }
    //        this.pRear.Next = node;
    //        this.length++;
    //    }
    //    public void InsertAtEnd(T data)
    //    {
    //        SNode<T> node = new SNode<T>(data, this.pRear.Next);
    //        this.pRear.Next = node;
    //        this.pRear = node;
    //        if (this.length == 0) {
    //            this.pRear.Next = node;
    //        }
    //        this.length++;
    //    }
    //    public void Insert(int index, T data) 
    //    {
    //        if (index < 0 || index > this.length)
    //        {
    //            throw new Exception("索引值有错误");
    //        }
    //        if (index == 0)
    //        {
    //            InsertAtFirst(data);
    //        }
    //        else if (index == this.length)
    //        {
    //            InsertAtEnd(data);
    //        }
    //        else
    //        {
    //            SNode<T> node = new SNode<T>(data,Locate(index));
    //            Locate(index - 1).Next = node;
    //            this.length++;
    //        }
    //    }
    //    public void Remove(int index)
    //    {
    //        if (index < 0 || index > this.length - 1 || this.length == 0)
    //        {
    //            throw new Exception("索引值的传入有错误");
    //        }
    //        if (this.length == 1 && index == 0) 
    //        {
    //            Clear();
    //        }
    //        if (index == 0)
    //        {
    //            this.pRear.Next = this.pRear.Next.Next;
    //        }
    //        else 
    //        {
    //            Locate(index - 1).Next = Locate(index).Next; 
    //        }
    //        this.length--;
    //    }
    //    public void Clear() 
    //    {
    //        this.length = 0;
    //        this.pRear = null;
    //    }
    //    public bool IsEmpty()
    //    {
    //        return this.length == 0 ? true : false;
    //    }
    //    public int Search(T data)
    //    {
    //        SNode<T> temp = this.pRear.Next;
    //        for (int i = 0; i < this.length; i++)
    //        {
    //            if (temp.Data.Equals(data))
    //            {
    //                return i;
    //            }
    //            temp = temp.Next;
    //        }
    //        return -1;
    //    }
    //    public override string ToString()
    //    {
    //        string str = "";
    //        SNode<T> temp = this.pRear.Next;
    //        for (int i = 0; i < this.length; i++)
    //        {
    //            str += temp.Data + "下一个的数据是:" + temp.Next.Data + "\n";
    //            temp = temp.Next;
    //        }
    //        return str;
    //    }
    //}
    // 双链表
    //public class DLinkList<T> : ILinearList<T>
    //{
    //    private int length;
    //    private Dnode<T> pHead;
    //    private Dnode<T> pRear;

    //    public DLinkList()
    //    {
    //        this.length = 0;
    //        this.pHead = null;
    //        this.pRear = null;
    //    }

    //    public int Length
    //    {
    //        get { return this.length; }
    //    }

    //    public T this[int index]
    //    {
    //        get
    //        {
    //            if (index < 0 || index > this.length - 1) throw new Exception("索引值传入有错");
    //            return Locate(index).Data;
    //        }
    //        set
    //        {
    //            if (index < 0 || index > this.length - 1) throw new Exception("索引值传入有错");
    //            Locate(index).Data = value;
    //        }
    //    }
    //    private Dnode<T> Locate(int index)
    //    {
    //        if (index < 0 || index > this.length - 1) throw new Exception("索引值传入有错");
    //        Dnode<T> temp = this.pHead;
    //        for (int i = 0; i < index; i++)
    //        {
    //            temp = temp.Next;
    //        }
    //        return temp;
    //    }
    //    public void InsertAtFirst(T data)
    //    {
    //        if (this.length == 0)
    //        {
    //            Dnode<T> node = new Dnode<T>(data);
    //            this.pRear = node;
    //            this.pHead = node;
    //        }
    //        else
    //        {
    //            Dnode<T> node = new Dnode<T>(null, data, this.pHead);
    //            this.pHead.Prior = node;
    //            this.pHead = node;
    //        }
    //        this.length++;
    //    }
    //    public void InsertAtEnd(T data)
    //    {
    //        if (this.length == 0)
    //        {
    //            Dnode<T> node = new Dnode<T>(data);
    //            this.pHead = node;
    //            this.pRear = node;
    //        }
    //        else
    //        {
    //            Dnode<T> node = new Dnode<T>(this.pRear, data, null);
    //            this.pRear.Next = node;
    //            this.pRear = node;
    //        }
    //        this.length++;
    //    }
    //    public bool IsEmpty()
    //    {
    //        return this.length == 0 ? true : false;
    //    }

    //    public void Insert(int index, T data)
    //    {
    //        if (index < 0 || index > this.length) throw new Exception("索引值传入有错");
    //        if (index == 0) InsertAtFirst(data);
    //        else if (index == this.length) InsertAtEnd(data);
    //        else
    //        {
    //            Dnode<T> temp = new Dnode<T>(Locate(index - 1), data, Locate(index));
    //            Locate(index - 1).Next = temp;
    //            Locate(index).Prior = temp;
    //            this.length++;
    //        }
    //    }

    //    public void Clear()
    //    {
    //        this.length = 0;
    //        this.pRear = null;
    //        this.pHead = null;
    //    }

    //    public void Remove(int index)
    //    {
    //        if (index < 0 || index > this.length - 1 || this.length == 0) throw new Exception("索引值传入有错");
    //        if (index == 0)
    //        {
    //            this.pHead = this.pHead.Next;
    //            this.pHead.Prior = null;
    //        }
    //        else if (index == this.length - 1)
    //        {
    //            this.pRear = this.pRear.Prior;
    //            this.pRear.Next = null;
    //        }
    //        else
    //        {
    //            Dnode<T> temp = Locate(index);
    //            temp.Prior.Next = temp.Next;
    //            temp.Next.Prior = temp.Prior;
    //        }
    //        this.length--;
    //    }

    //    public int Search(T data)
    //    {
    //        Dnode<T> temp = this.pHead;
    //        for (int i = 0; i < this.length; i++)
    //        {
    //            if (temp.Data.Equals(data) == true)
    //            {
    //                return i;
    //            }
    //            temp = temp.Next;
    //        }
    //        return -1;
    //    }
    //}
    // 顺序存储栈
    //public class SeqStack<T> : IStack<T> 
    //{
    //    private LinearList<T> list;
    //    public int Length
    //    {
    //        get 
    //        {
    //            return list.Length;
    //        }
    //    }
    //    public int MaxSize 
    //    {
    //        get 
    //        {
    //            return list.MaxSize;
    //        }
    //    }
    //    public T StackTop 
    //    {
    //        get 
    //        {
    //            if (list.Length == 0)
    //            {
    //                throw new Exception("栈最大的容量为0");
    //            } 
    //            return list[0];
    //        }
    //    }
    //    public SeqStack(int max)
    //    {
    //        if (max <= 0) throw new Exception("传入长度需要大于1");
    //        list = new LinearList<T>(max);
    //    }
    //    public void Push(T data) 
    //    {
    //        if (list.Length == list.MaxSize) throw new Exception("栈已经达到了最大容量");
    //        list.Insert(0 ,data);
    //    }
    //    public void Pop() 
    //    {
    //        if (list.Length == 0) throw new Exception("栈为空");
    //        list.Remove(0);
    //    }
    //    public bool IsEmpty() 
    //    {
    //        return list.IsEmpty();
    //    }
    //    public void Clear() 
    //    {
    //        list.Clear();
    //    }
    //}
    // 链式存储栈
    //public class LinkStack<T> : IStack<T> 
    //{
    //    private SLinkList<T> _list;
    //    public int Length
    //    {
    //        get 
    //        {
    //            return _list.Length;
    //        }
    //    }
    //    public T StackTop 
    //    {
    //        get 
    //        {
    //            return _list[0];
    //        }
    //    }
    //    public LinkStack() 
    //    {
    //        _list = new SLinkList<T>();
    //    }
    //    public void Push(T data) 
    //    {
    //        _list.InsertAtFirst(data);
    //    }
    //    public void Pop() 
    //    {
    //        if (_list.Length == 0) throw new Exception("栈为空");
    //        _list.Remove(0);
    //    }
    //    public bool IsEmpty() 
    //    {
    //        return _list.IsEmpty();
    //    }
    //    public void Clear() 
    //    {
    //        _list.Clear();
    //    }
    //}
    // 顺序队列
    //public class SeqQueue<T> : IQueue<T> 
    //{
    //    private LinearList<T> list;
    //    public int Length
    //    {
    //        get
    //        {
    //            return list.Length;
    //        }
    //    }
    //    public int MaxSize
    //    {
    //        get
    //        {
    //            return list.MaxSize;
    //        }
    //    }
    //    public T QueueFront 
    //    {
    //        get 
    //        {
    //            if (list.Length == 0) 
    //            {
    //                throw new Exception("队列是空的");
    //            }
    //            return list[0];
    //        }
    //    }
    //    public SeqQueue(int max) 
    //    {
    //        if (max <= 0) 
    //        {
    //            throw new Exception("队列长度不能为0");
    //        }
    //        list = new LinearList<T>(max);
    //    }
    //    // 入队
    //    public void EnQueue(T data) 
    //    {
    //        if (list.Length == list.MaxSize) throw new Exception("队列已经满了");
    //        list.Insert(list.Length, data);
    //    }
    //    // 出队
    //    public void DeQueue() 
    //    {
    //        if (list.Length == 0) throw new Exception("队列为空");
    //        list.Remove(0);
    //    } 
    //    public bool IsEmpty()
    //    {
    //        return list.Length == 0;
    //    }
    //    public void Clear() 
    //    {
    //        list.Clear();
    //    }
    //}
    //// 顺序循环队列
    //public class CSeqQueue<T> : IQueue<T> 
    //{
    //    private T[] dataSet;
    //    private int pFront;
    //    private int pRear;
    //    private int length;
    //    private int maxSize;
    //    public int Length 
    //    {
    //        get 
    //        {
    //            return this.length;
    //        }
    //    }
    //    public T QueueFront 
    //    {
    //        get 
    //        {
    //            return dataSet[pFront];
    //        }
    //    }
    //    public CSeqQueue(int max) 
    //    {
    //        dataSet = new T[max];
    //        this.length = 0;
    //        this.pRear = 0;
    //        this.pFront = 0;
    //        this.maxSize = max;
    //    }
    //    public void EnQueue(T data) 
    //    {
    //        if (this.length == this.maxSize) throw new Exception("队列已经满了");
    //        dataSet[this.pRear] = data;
    //        this.length++;
    //        this.pRear = (this.pRear + 1) % this.maxSize;
    //    }
    //    // 出队,出队后这个元素仍然在内存中存储着
    //    public void DeQueue() 
    //    {
    //        if (this.length == 0) throw new Exception("队列为空");
    //        this.length--;
    //        this.pFront = (this.pFront + 1) % this.maxSize;
    //    }
    //    public bool IsEmpty() 
    //    {
    //        return this.length == 0;
    //    }
    //    public void Clear() 
    //    {
    //        this.length = 0;
    //        this.pRear = 0;
    //        this.pFront = 0;
    //    }
    //}
    //// 链式队列
    //public class LinkQueue<T> : IQueue<T> 
    //{
    //    private SLinkList<T> list;
    //    public int Length 
    //    {
    //        get 
    //        {
    //            return list.Length;
    //        }
    //    }
    //    public T QueueFront 
    //    {
    //        get 
    //        {
    //            return list[0];
    //        }
    //    }
    //    public LinkQueue() 
    //    {
    //        list = new SLinkList<T>();
    //    }
    //    public void EnQueue(T data) 
    //    {
    //        list.InsertAtEnd(data);
    //    }
    //    public void DeQueue() 
    //    {
    //        if (list.IsEmpty()) throw new Exception("队列为空");
    //        list.Remove(0);
    //    }
    //    public bool IsEmpty() 
    //    {
    //        return list.Length == 0;
    //    }
    //    public void Clear() 
    //    {
    //        list.Clear();
    //    }
    //}
    // 构造双链表节点 
    //public class Dnode<T>
    //{
    //    private T data;
    //    private Dnode<T> next;
    //    private Dnode<T> prior;
    //    public T Data
    //    {
    //        get
    //        {
    //            return this.data;
    //        }
    //        set
    //        {
    //            this.Data = value;
    //        }
    //    }
    //    public Dnode<T> Next
    //    {
    //        get
    //        {
    //            return this.next;
    //        }
    //        set
    //        {
    //            this.next = value;
    //        }
    //    }
    //    public Dnode<T> Prior
    //    {
    //        get
    //        {
    //            return this.prior;
    //        }
    //        set
    //        {
    //            this.prior = value;
    //        }
    //    }
    //    public Dnode(T data)
    //    {
    //        this.data = data;
    //    }
    //    public Dnode(Dnode<T> prior, T data, Dnode<T> next)
    //    {
    //        this.data = data;
    //        this.prior = prior;
    //        this.next = next;
    //    }
    //}
    // 动态数组
    //public class DArray<T>
    //{
    //    private T[] array;
    //    private int size;
    //    public int Size 
    //    {
    //        get 
    //        {
    //            return this.size;
    //        }
    //    }
    //    public DArray(int sz)
    //    {
    //        if (sz <= 0) throw new Exception("数组长度不能小于1啊");
    //        this.size = sz;
    //        this.array = new T[sz];
    //    }
    //    public void ReSize(int newSize)
    //    {
    //        if (newSize <= 0) throw new Exception("数组长度不能小于1啊");
    //        if (this.size != newSize)
    //        {
    //            T[] newArray = new T[newSize];
    //            int temp = Math.Min(size, newSize);
    //            for (int i = 0; i < temp; i++)
    //            {
    //                newArray[i] = this.array[i];
    //            }
    //            this.array = newArray;
    //            this.size = newSize;
    //        }
    //    }
    //    public T this[int index]
    //    {
    //        get 
    //        {
    //            if (index < 0 || index >= this.size) throw new Exception("索引值有错啊");
    //            return this.array[index];
    //        }
    //        set 
    //        {
    //            if (index < 0 || index >= this.size) throw new Exception("索引值有错啊");
    //            array[index] = value;
    //        }
    //    }
    //}
    // 三元组
    //public class Triple 
    //{
    //    private int rows;
    //    private int cols;
    //    private double val;
    //    public int Rows 
    //    {
    //        get
    //        {
    //            return this.rows;
    //        }
    //    }
    //    public int Cols
    //    {
    //        get
    //        {
    //            return this.cols;
    //        }
    //    }
    //    public double Val
    //    {
    //        get 
    //        {
    //            return this.val;
    //        }
    //        set 
    //        {
    //            this.val = value;
    //        }
    //    }
    //    public Triple(int i, int j, double val) 
    //    {
    //        if (i < 0 || j < 0) throw new Exception("行列传入有错");
    //        this.rows = i;
    //        this.cols = j;
    //        this.val = val;
    //    }
    //    public override string ToString() 
    //    {
    //        return string.Format("({0},{1},{2})", this.rows,this.cols ,this.val);
    //    }
    //}
    // 稀疏矩阵
    //public class Matrix : IMatrix 
    //{
    //    private int rows;
    //    private int cols;
    //    private SLinkList<Triple> list = new SLinkList<Triple>();

    //    public int Rows 
    //    {
    //        get 
    //        {
    //            return this.rows;
    //        }
    //    }
    //    public int Cols 
    //    {
    //        get 
    //        {
    //            return this.cols;
    //        }
    //    }
    //    public Matrix(int rows, int cols)
    //    {
    //        if (rows < 0 || cols < 0) throw new Exception("行列传入有错");
    //        this.rows = rows;
    //        this.cols = cols;
    //    }
    //    public double this[int i, int j] 
    //    {
    //        get 
    //        {
    //            if (i < 0 || i > this.rows - 1 || j < 0 || j > this.cols - 1) 
    //            {
    //                throw new Exception("索引值传入有错误");
    //            }
    //            for (int k = 0; k < list.Length; k++) 
    //            {
    //                if (list[k].Cols == j && list[k].Rows == i) 
    //                {
    //                    return list[k].Val;
    //                }
    //            }
    //            return 0.0;
    //        }
    //        set 
    //        {
    //            if (i < 0 || i > this.rows - 1 || j < 0 || j > this.cols - 1)
    //            {
    //                throw new Exception("索引值传入有错误");
    //            }
    //            int k;
    //            for (k = 0; k < list.Length; k++)
    //            {
    //                if (list[k].Cols == j && list[k].Rows == i)
    //                {
    //                    break;
    //                }
    //            }
    //            if (k == list.Length)
    //            {
    //                if (value != 0)
    //                {
    //                    Triple node = new Triple(i, j, value);
    //                    list.InsertAtEnd(node);
    //                }
    //            }
    //            else 
    //            {
    //                if (value == 0)
    //                {
    //                    list.Remove(k);
    //                }
    //                else 
    //                {
    //                    list[k].Val = value;
    //                }
    //            }
    //        }
    //    }
    //    public IMatrix Add(IMatrix B) 
    //    {
    //        if (B == null) throw new Exception("请传入一个矩阵");
    //        if (this.cols != B.Cols || this.rows != B.Rows) throw new Exception("矩阵传入有错误");
    //        Matrix temp = new Matrix(this.rows,this.cols);
    //        for (int i = 0; i < this.rows; i++) 
    //        {
    //            for (int j = 0; j < this.cols; j++) 
    //            {
    //                temp[i, j] = this[i, j] + B[i, j];
    //            }
    //        }
    //        return temp;
    //    }
    //    public static Matrix operator +(Matrix A, Matrix B) 
    //    {
    //        if (A == null || B == null) 
    //        {
    //            throw new Exception("矩阵传入有错误");
    //        }
    //        return A.Add(B) as Matrix;
    //    }
    //    public IMatrix Transpose() 
    //    {
    //        Matrix temp = new Matrix(this.cols,this.rows);
    //        for (int i = 0; i < this.cols; i++) 
    //        {
    //            for (int j = 0; j < this.rows; j++) 
    //            {
    //                temp[i, j] = this[j, i];
    //            }
    //        }
    //        return temp;
    //    }
    //    public IMatrix Multiply(IMatrix B) 
    //    {
    //        if (B == null) throw new Exception("请传入一个矩阵");
    //        if (B.Rows != this.cols) throw new Exception("矩阵传入有错误");
    //        Matrix temp = new Matrix(this.rows,B.Cols);
    //        for (int i = 0; i < this.rows; i++) 
    //        {
    //            for (int j = 0; j < B.Cols; j++) 
    //            {
    //                for (int k = 0; k < this.cols; k++) 
    //                {
    //                    temp[i, j] += this[i, k] * B[k, j];
    //                }
    //            } 
    //        }
    //        return temp;
    //    }
    //    public static Matrix operator  *(Matrix A, Matrix B) 
    //    {
    //        if (A == null || B == null) throw new Exception("参数传入有错误");
    //        return A.Multiply(B) as Matrix;
    //    }
    //    public override string ToString() 
    //    {
    //        string str = "";
    //        for (int i = 0; i < list.Length; i++) 
    //        {
    //            str += list[i].ToString() + "\n";
    //        }
    //        return str;
    //    }
    //}
    // 串
    //public class SeqString : IString
    //{
    //    private char[] Cstr;
    //    public int Length
    //    {
    //        get
    //        {
    //            int i = 0;
    //            while (this.Cstr[i] != '\0') 
    //            {
    //                i++;
    //            }
    //            return i;
    //        }
    //    }
    //    public char this[int index]
    //    {
    //        get
    //        {
    //            if (index < 0 || index > this.Cstr.Length - 1)
    //            {
    //                throw new Exception("索引位置传入有错");
    //            }
    //            return this.Cstr[index];
    //        }
    //        set
    //        {
    //            if (index < 0 || index > this.Cstr.Length - 1)
    //            {
    //                throw new Exception("索引位置传入有错");
    //            }
    //            this.Cstr[index] = value;
    //        }
    //    }
    //    // 构造函数
    //    public SeqString()
    //    {
    //        this.Cstr = new char[] { '\0' };
    //    }
    //    public SeqString(String s)
    //    {
    //        if (s == null) throw new Exception("传入字符串为空");
    //        int len = s.Length;
    //        this.Cstr = new char[len + 1];
    //        for (int i = 0; i < len; i++)
    //        {
    //            this.Cstr[i] = s[i];
    //        }
    //        this.Cstr[len] = '\0';
    //    }
    //    public SeqString(int len)
    //    {
    //        if (len < 0) throw new Exception("字符串长度不能为0");
    //        this.Cstr = new char[len + 1];
    //        this.Cstr[len] = '\0';
    //    }
    //    public IString Insert(int index, IString s)
    //    {
    //        if (s == null)
    //        {
    //            throw new Exception("插入子串有错");
    //        }
    //        if (index < 0 || index > this.Cstr.Length)
    //        {
    //            throw new Exception("插入位置有错");
    //        }
    //        int len = this.Cstr.Length + s.Length;
    //        SeqString str = new SeqString(len);
    //        for (int i = 0; i < index; i++) 
    //        {
    //            str.Cstr[i] = this.Cstr[i];
    //        }
    //        for (int i = 0; i < s.Length; i++) 
    //        {
    //            str.Cstr[i + index] = s[i];
    //        }
    //        for (int i = index; i < this.Cstr.Length; i++) 
    //        {
    //            str.Cstr[i + s.Length] = this.Cstr[i];
    //        }
    //        return str;
    //    }
    //    public IString Remove(int start, int count) 
    //    {
    //        if (start < 0 || start > this.Cstr.Length - 1) 
    //        {
    //            throw new Exception("开始位置有错");
    //        }
    //        if (count < 0) 
    //        {
    //            throw new Exception("移除的字符串长度小于0");
    //        }
    //        int maxOut = this.Cstr.Length - start;
    //        count = count < maxOut ? count : maxOut;
    //        SeqString str = new SeqString(this.Cstr.Length - count); 
    //        for (int i = 0; i < start; i++) 
    //        {
    //            str[i] = this.Cstr[i];
    //        }
    //        for (int i = start + count; i < this.Cstr.Length; i++) 
    //        {
    //            str[i - count] = this.Cstr[i];
    //        }
    //        return str;
    //    }
    //    // 截取字符串(返回值为截取完的子串)
    //    public IString SubString(int start, int count) 
    //    {
    //        if (start < 0 || start > this.Cstr.Length - 1) 
    //        {
    //            throw new Exception("开始位置传入有错");
    //        }
    //        if (count < 0) 
    //        {
    //            throw new Exception("截取长度小于0");
    //        }
    //        int left = this.Cstr.Length - start;
    //        count = count > left ? left : count;
    //        IString str = new SeqString(count);
    //        for (int i = start; i < count; i++) 
    //        {
    //            str[i - start] = this.Cstr[i];
    //        }
    //        return str;
    //    }
    //    public IString Clone() 
    //    {
    //        SeqString str = new SeqString(this.Cstr.Length);
    //        for (int i = 0; i < this.Cstr.Length; i++) 
    //        {
    //            str.Cstr[i] = this.Cstr[i];
    //        }
    //        return str;
    //    }
    //    public IString concat(IString s) 
    //    {
    //        if (s == null) throw new Exception("连接字符串为空");
    //        return this.Insert(this.Length, s);
    //    }
    //    public static SeqString operator + (SeqString s1, SeqString s2)
    //    {
    //        if (s1 == null || s2 == null) 
    //        {
    //            throw new Exception("含有空字符串");
    //        }
    //        return s1.concat(s2) as SeqString;
    //    }
    //    public override string ToString ()
    //    {
    //        string str = string.Empty;
    //        for (int i = 0; i < this.Cstr.Length - 1; i++) 
    //        {
    //            str += this.Cstr[i];
    //        }
    //        return str;
    //    }
    //    public int FindParam(IString s) 
    //    {
    //        if (s == null || s.Length == 0) 
    //        {
    //            throw new Exception("参数字符串传入有错");
    //        }
    //        int j = 0;
    //        for (int i = 0; i <= this.Cstr.Length - s.Length; i++) 
    //        {
    //            if (this.Cstr[i] == s[0]) 
    //            {
    //                for (j = 1; j < s.Length; j++) 
    //                {
    //                    if (this.Cstr[i + j] != s[j]) break;
    //                }
    //            }
    //            if (j == s.Length) return i;
    //        }
    //        return -1;
    //    }
    //    // 去除俩边空格
    //    public IString Trim() 
    //    {
    //        string str = string.Empty;
    //        int i, j;
    //        for (i = 0; i < this.Length - 1; i++) 
    //        {
    //            if (this.Cstr[i] != ' ') break;
    //        }
    //        if (i == this.Length - 1) return new SeqString();
    //        for (j = this.Length - 1; j >= 0; j--) 
    //        {
    //            if (this.Cstr[j] != ' ') break;
    //        }
    //        for (int k = i; k <= j; k++) 
    //        {
    //            str += this.Cstr[k];
    //        }
    //        return new SeqString(str);
    //    }
    //    // 替换字符串
    //    public IString Replace(string pattern, string replacement, int num) 
    //    {
    //        if (pattern.Length > this.Length) throw new Exception("子串过于大");
    //        int i;
    //        string str = string.Empty;
    //        for (i = num; i < this.Length; i++) 
    //        {
    //            if (this.Cstr[i] == pattern[0])
    //            {
    //                int j;
    //                for (j = 1; j < pattern.Length; j++)
    //                {
    //                    if (this.Cstr[i + j] != pattern[j])
    //                    {
    //                        break;
    //                    }
    //                }
    //                if (j == pattern.Length)
    //                {
    //                    str += replacement;
    //                    i += pattern.Length - 1;
    //                    continue;
    //                }
    //            }
    //            str += this.Cstr[i];  
    //        }
    //        Console.WriteLine("{0}", str);
    //        return new SeqString(str);
    //    }
    //    // 在左边添加元素达到指定长度
    //    public IString paddingLeft(int max, string a) 
    //    {
    //        if (max <= this.Length) throw new Exception("串已经达到该长度");
    //        if (a == string.Empty) throw new Exception("传入的是空字符");
    //        string str = this.ToString();
    //        for (int i = 0; i < max - this.Length; i++) 
    //        {
    //            str = a + str;
    //        }
    //        return new SeqString(str);
    //    }
    //}
    // 数
    //public class IntSet : ISet<uint, IntSet> 
    //{
    //    private uint[] bitSet;
    //    private uint maxRange;
    //    public uint MaxRange 
    //    {
    //        get 
    //        {
    //            return this.maxRange;
    //        }
    //    }
    //    public IntSet(uint max) 
    //    {
    //        uint i,len;
    //        this.maxRange = max;
    //        len = max / 32 + 1;
    //        this.bitSet = new uint[len];
    //        for (i = 0; i < len; i++) 
    //        {
    //            bitSet[i] = 0;
    //        }
    //    }
    //    // 获取元素在数组中的索引
    //    private uint ArrayIndex(uint elt) 
    //    {
    //        if (elt > this.maxRange) throw new Exception("不在范围内");
    //        return elt / 32;
    //    }
    //    // 获取元素对应位置的整数
    //    private uint BitMask(uint elt) 
    //    {
    //        if (elt > this.maxRange) throw new Exception("不在范围内");
    //        return (uint)Math.Pow(2, elt % 32);            
    //    }
    //    public void Insert(uint elt) 
    //    {
    //        if (elt > this.maxRange) throw new Exception("超出范围");
    //        this.bitSet[this.ArrayIndex(elt)] |= this.BitMask(elt);     
    //    }
    //    public void Remove(uint elt) 
    //    {
    //        if (elt > this.maxRange) throw new Exception("超出范围");
    //        this.bitSet[this.ArrayIndex(elt)] &= ~this.BitMask(elt);
    //    }
    //    public bool isMember(uint elt) 
    //    {
    //        if (elt > this.maxRange) return false;
    //        uint i = this.bitSet[this.ArrayIndex(elt)] & this.BitMask(elt);
    //        return i != 0;
    //    }
    //    // 获取对象二进制字符串
    //    public string GetBitString() 
    //    {
    //        string str = string.Empty;
    //        for (int i = 0; i < this.bitSet.Length; i++) 
    //        {
    //            str = Convert.ToString(bitSet[i], 2).PadLeft(32, '0') + str;
    //        }
    //        return str.Remove(0, (int)maxRange % 32 + 1);
    //    }
    //    // 得到集合中的所有元素
    //    public string GetElement() 
    //    {
    //        string S = this.GetBitString();
    //        string str = string.Empty;
    //        int j = 0;
    //        for (int i = S.Length - 1; i >= 0; i--)
    //        {
    //            if (S[i] == '1') str += j.ToString() + " ";
    //            j++;
    //        }
    //        return str;
    //    }
    //    // 判断两个集合是否相等
    //    public bool Equals(IntSet B) 
    //    {
    //        if (B == null) throw new Exception("未传入集合");
    //        if (B.MaxRange != this.maxRange) return false;
    //        return B.GetBitString() == this.GetBitString();
    //    }
    //    // 得到两个集合的交集
    //    public IntSet Intersect(IntSet B) 
    //    {
    //        if (B == null) throw new Exception("未传入集合");
    //        if (B.MaxRange != this.maxRange) throw new Exception("两个集合的范围不同");
    //        IntSet result = new IntSet(this.maxRange);
    //        for (int i = 0; i < this.bitSet.Length; i++) 
    //        {
    //            result.bitSet[i] = this.bitSet[i] & B.bitSet[i];
    //        }
    //        return result;
    //    }
    //    // 得到两个集合的并集
    //    public IntSet Union(IntSet B) 
    //    {
    //        if (B == null) throw new Exception("未传入集合");
    //        if (B.MaxRange != this.maxRange) throw new Exception("两个集合的范围不同");
    //        IntSet result = new IntSet(this.maxRange);
    //        for (int i = 0; i < this.bitSet.Length; i++)
    //        {
    //            result.bitSet[i] = this.bitSet[i] | B.bitSet[i];
    //        }
    //        return result;
    //    }
    //    // 得到两个集合的差集
    //    public IntSet DiffSet(IntSet B) 
    //    {
    //        if (B == null) throw new Exception("未传入集合");
    //        if (B.MaxRange != this.maxRange) throw new Exception("两个集合的范围不同");
    //        IntSet result = new IntSet(this.maxRange);
    //        for (int i = 0; i < this.bitSet.Length; i++)
    //        {
    //            result.bitSet[i] = this.bitSet[i] & (~B.bitSet[i]);
    //        }
    //        return result;
    //    }
    //    // 得到集合的补集
    //    public IntSet Complement() 
    //    {
    //        IntSet result = new IntSet(this.maxRange);
    //        for (int i = 0; i < this.bitSet.Length; i++) 
    //        {
    //            result.bitSet[i] = ~(this.bitSet[i]);
    //        }
    //        return result;
    //    }
    //    // 判断集合是否为其子集
    //    public bool IsSubSet(IntSet B) 
    //    {
    //        if (B == null) throw new Exception("未传入集合");
    //        if (B.MaxRange != this.maxRange) throw new Exception("两个集合的范围不同");
    //        for (int i = 0; i < this.bitSet.Length; i++) 
    //        {
    //            uint temp = this.bitSet[i] | B.bitSet[i];
    //            if (temp != this.bitSet[i]) return false;
    //        }
    //        return true;
    //    }
    //}
    //// 二叉树节点结构
    //public class BinTreeNode<T> 
    //{
    //    private T data;
    //    private BinTreeNode<T> leftChild;
    //    private BinTreeNode<T> rightChild;
    //    public T Data 
    //    {
    //        get 
    //        {
    //            return this.data;
    //        }
    //        set 
    //        {
    //            this.data = value;
    //        }
    //    }
    //    public BinTreeNode<T> LeftChild 
    //    {
    //        get 
    //        {
    //            return this.leftChild;
    //        }
    //        set 
    //        {
    //            this.leftChild = value;
    //        }
    //    }
    //    public BinTreeNode<T> RightChild 
    //    {
    //        get 
    //        {
    //            return this.rightChild;
    //        }
    //        set 
    //        {
    //            this.rightChild = value;
    //        }
    //    }
    //    // 无子节点构造函数
    //    public BinTreeNode(T data) 
    //    {
    //        if (data == null) throw new Exception("节点数据不能为空");
    //        this.data = data;
    //        this.leftChild = null;
    //        this.rightChild = null;
    //    }
    //    // 含有子节点的构造函数
    //    public BinTreeNode(BinTreeNode<T> lChild, T data, BinTreeNode<T> rChild) 
    //    {
    //        if (data == null) throw new Exception("节点数据不能为空");
    //        this.data = data;
    //        this.leftChild = lChild;
    //        this.rightChild = rChild;
    //    }
    //}
    //// 二叉树
    //public class BinTree<T> 
    //{
    //    private string orderString;
    //    private BinTreeNode<T> root;
    //    public BinTreeNode<T> Root 
    //    {
    //        get 
    //        {
    //            return this.root;
    //        }
    //        set 
    //        {
    //            this.root = value;
    //        }
    //    }
    //    // 构造函数
    //    public BinTree(BinTreeNode<T> root) 
    //    {
    //        this.root = root;
    //    }
    //    // 向二叉树中插入节点
    //    public void Insert(BinTreeNode<T> current, BinTreeNode<T> leftchild, BinTreeNode<T> rightchild) 
    //    {
    //        if (root == null) throw new Exception("树为空");
    //        if (current == null) throw new Exception("插入节点不能为空");
    //        current.LeftChild = leftchild;
    //        current.RightChild = rightchild;
    //    }
    //    // 先序遍历
    //    private void PreOrder(BinTreeNode<T> current)  
    //    {
    //        if (current == null) return;
    //        this.orderString += current.Data.ToString() + " ";
    //        this.PreOrder(current.LeftChild);
    //        this.PreOrder(current.RightChild);
    //    }
    //    public string PreOrderTraversal() 
    //    {
    //        this.orderString = string.Empty;
    //        PreOrder(this.root);
    //        return this.orderString.Trim();
    //    }
    //    // 中序遍历
    //    private void MidOrder(BinTreeNode<T> current)
    //    {
    //        if (current == null) return;
    //        MidOrder(current.LeftChild);
    //        orderString += current.Data.ToString() + " ";
    //        MidOrder(current.RightChild);
    //    }
    //    public string MidOrderTraversal() 
    //    {
    //        this.orderString = string.Empty;
    //        MidOrder(this.root);
    //        return this.orderString.Trim();
    //    }
    //    // 后序遍历
    //    private void PostOrder(BinTreeNode<T> current)
    //    {
    //        if (current == null) return;
    //        PostOrder(current.LeftChild);
    //        PostOrder(current.RightChild);
    //        orderString += current.Data.ToString() + " ";
    //    }
    //    public string PostOrderTraversal() 
    //    {
    //        this.orderString = string.Empty;
    //        PostOrder(this.root);
    //        return this.orderString;
    //    }
    //    // 层级遍历,利用队列(从根节点开始入队)
    //    public string LevelTraversal() 
    //    {
    //        this.orderString = string.Empty;
    //        if (root == null) return this.orderString;
    //        LinkQueue<BinTreeNode<T>> LQ = new LinkQueue<BinTreeNode<T>>();
    //        LQ.EnQueue(this.root);
    //        while (LQ.IsEmpty() == false) 
    //        {
    //            BinTreeNode<T> temp = LQ.QueueFront;
    //            LQ.DeQueue();
    //            orderString += temp.Data.ToString() + " ";
    //            if (temp.LeftChild != null) LQ.EnQueue(temp.LeftChild);
    //            if (temp.RightChild != null) LQ.EnQueue(temp.RightChild);
    //        }
    //        return this.orderString.Trim();
    //    }
    //    // 找父节点
    //    private BinTreeNode<T> FindParent(BinTreeNode<T> current, BinTreeNode<T> find) 
    //    {
    //        if (find == null) throw new Exception("出入参数有错");
    //        if (current == null) return null;
    //        if (current.LeftChild != null && current.LeftChild.Equals(find)) 
    //        {
    //            return current;
    //        }
    //        if (current.RightChild != null && current.RightChild.Equals(find)) 
    //        {
    //            return current;
    //        }
    //        BinTreeNode<T> temp = FindParent(current.LeftChild, find);
    //        if (temp != null)
    //        {
    //            return temp;
    //        }
    //        else 
    //        {
    //            return FindParent(current.RightChild, find);
    //        }
    //    }
    //    public BinTreeNode<T> GetParent(BinTreeNode<T> find) 
    //    {
    //        if (find == null) throw new Exception("传入参数为null");
    //        return FindParent(root, find);
    //    }
    //    // 找左兄弟节点
    //    public BinTreeNode<T> GetLeftSibling(BinTreeNode<T> current) 
    //    {
    //        if (current == null) throw new Exception("参数传入有错");
    //        BinTreeNode<T> parent = GetParent(current);
    //        if (parent != null && parent.LeftChild != null && parent.LeftChild.Equals(current) == false)
    //        {
    //            return parent.LeftChild;
    //        }
    //        else 
    //        {
    //            return null;
    //        }
    //    }
    //    // 找右兄弟节点
    //    public BinTreeNode<T> GetRightSibling(BinTreeNode<T> current) 
    //    {
    //        if (current == null) throw new Exception("参数传入有错");
    //        BinTreeNode<T> parent = GetParent(current);
    //        if (parent != null && parent.RightChild != null && parent.RightChild.Equals(current) == false)
    //        {
    //            return parent.RightChild;
    //        }
    //        else
    //        {
    //            return null;
    //        }
    //    }
    //    // 删除节点
    //    public void DeleteSubTree(BinTreeNode<T> current) 
    //    {
    //        if (current == null) throw new Exception("传入参数有误");
    //        if (this.root == null) throw new Exception("树为空");
    //        if (root.Equals(this.root))
    //        {
    //            this.root = null;
    //        }
    //        else 
    //        {
    //            BinTreeNode<T> parent = GetParent(current);
    //            if (parent != null && parent.LeftChild != null && parent.LeftChild.Equals(current)) 
    //            {
    //                parent.LeftChild = null;
    //            }
    //            if (parent != null && parent.RightChild != null && parent.LeftChild.Equals(current)) 
    //            {
    //                parent.RightChild = null;
    //            }
    //        }
    //    }
    //    // 寻找对应节点
    //    private BinTreeNode<T> FindData(BinTreeNode<T> current, T data) 
    //    {
    //        if (data == null) throw new Exception("出入参数有误");
    //        if (current == null) return null;
    //        if (current.Data.Equals(data)) return current;
    //        BinTreeNode<T> temp = FindData(current.LeftChild, data);
    //        if (temp != null)
    //        {
    //            return temp;
    //        }
    //        else 
    //        {
    //            return FindData(current.RightChild, data);
    //        }
    //    }
    //    public BinTreeNode<T> Search(T data) 
    //    {
    //        if (data == null) throw new Exception("参数传入有错");
    //        return FindData(root, data);
    //    }
    //    // 叶子节点数量
    //    private void FindLeafCount(BinTreeNode<T> current, ref int count) 
    //    {
    //        if (current == null) return;
    //        if (current.LeftChild == null && current.RightChild == null) 
    //        {
    //            ++count;
    //            return;
    //        }
    //        FindLeafCount(current.LeftChild, ref count);
    //        FindLeafCount(current.RightChild, ref count);
    //    }
    //    public int GetLeafCount() 
    //    {
    //        int count = 0;
    //        FindLeafCount(this.root, ref count);
    //        return count;
    //    }
    //    // 交换左右节点
    //    private void Exchange(BinTreeNode<T> current) 
    //    {
    //        if (current == null) return;
    //        if (current.LeftChild != null || current.RightChild != null) 
    //        {
    //            BinTreeNode<T> temp = current.LeftChild;
    //            current.LeftChild = current.RightChild;
    //            current.RightChild = temp;
    //        }
    //        if (current.LeftChild != null) 
    //        {
    //            Exchange(current.LeftChild);
    //        }
    //        if (current.RightChild != null) 
    //        {
    //            Exchange(current.RightChild);
    //        }
    //    }
    //    public void Exchange() 
    //    {
    //        Exchange(root);
    //    }
    //}
    // 图(存邻接矩阵)
    //public class MGraph
    //{
    //    // 二维邻接矩阵
    //    private double[,] adMatrix;
    //    // 存储图中各个节点名字的数组
    //    private string[] vertexNameList;
    //    // 图中节点个数
    //    private int vertextCount;
    //    public int VertextCount 
    //    {
    //        get 
    //        {
    //            return this.vertextCount;
    //        }
    //    }
    //    public string this[int index] 
    //    {
    //        get 
    //        {
    //            if (index < 0 || index > this.vertexNameList.Length - 1) 
    //            {
    //                throw new Exception("索引位置传入有错");
    //            }
    //            return this.vertexNameList[index];
    //        }
    //        set 
    //        {
    //            if (index < 0 || index > this.vertexNameList.Length - 1)
    //            {
    //                throw new Exception("索引位置传入有错");
    //            }
    //            this.vertexNameList[index] = value;
    //        }
    //    }
    //    public MGraph(int vCount) 
    //    {
    //        if (vCount < 0) throw new Exception("图中节点个数不能小于0");
    //        this.vertexNameList = new string[vCount];
    //        this.vertextCount = vCount;
    //        this.adMatrix = new double[vCount, vCount];
    //    }
    //    // 找出对应名字的节点的索引
    //    private int GetIndex(string Vertexname) 
    //    {
    //        int i;
    //        for (i = 0; i < this.vertextCount; i++) 
    //        {
    //            if (this.vertexNameList[i] == Vertexname)
    //                break;
    //        }
    //        return i == this.vertextCount ? -1 : i;
    //    }
    //    // 给邻接矩阵赋值
    //    public void AddEdge(string startVertextName, string endVertextName, double weight) 
    //    {
    //        int i = this.GetIndex(startVertextName);
    //        int j = this.GetIndex(endVertextName);
    //        if (i == -1 || j == -1) throw new Exception("所传入的起始位置与");
    //        this.adMatrix[i, j] = weight;
    //    }
    //}
    //// 邻接表-边表节点
    //public class EdgeNode 
    //{

    //    private int index;
    //    private double weight;
    //    private EdgeNode next;
    //    // 无next节点的构造函数
    //    public EdgeNode(int index, double weight) 
    //    {
    //        if (index < 0) 
    //        {
    //            throw new Exception("索引值传入有错误");
    //        }
    //        this.index = index;
    //        this.weight = weight;
    //        this.next = null;
    //    }
    //    // 有next节点的构造函数
    //    public EdgeNode(int index, double weight, EdgeNode next) 
    //    {
    //        if (index < 0)
    //        {
    //            throw new Exception("索引值传入有错误");
    //        }
    //        this.index = index;
    //        this.weight = weight;
    //        this.next = next;
    //    }
    //    public int Index
    //    {
    //        get 
    //        {
    //            return this.index;
    //        }
    //    }
    //    public double Weight 
    //    {
    //        get 
    //        {
    //            return this.weight;
    //        }
    //    }
    //    public EdgeNode Next 
    //    {
    //        get 
    //        {
    //            return this.next;
    //        }
    //        set 
    //        {
    //            this.next = value;
    //        }
    //    }
    //}
    //// 邻接表-顶点节点
    //public class VertexNode 
    //{
    //    private string vertextName;

    //    public string VertextName
    //    {
    //        get { return vertextName; }
    //        set { vertextName = value; }
    //    }
    //    private bool visited;

    //    public bool Visited
    //    {
    //        get { return visited; }
    //        set { visited = value; }
    //    }
    //    private EdgeNode firstNode;

    //    public EdgeNode FirstNode
    //    {
    //        get { return firstNode; }
    //        set { firstNode = value; }
    //    }
    //    public VertexNode(string name) 
    //    {
    //        this.vertextName = name;
    //        this.visited = false;
    //        this.firstNode = null;
    //    }
    //    public VertexNode(string name, EdgeNode first) 
    //    {
    //        this.vertextName = name;
    //        this.visited = false;
    //        this.firstNode = first;
    //    }
    //}
    //// 邻接表
    //public class AdGraph 
    //{
    //    private VertexNode[] vertexList;
    //    private int vertexCount;
    //    public int VertexCount
    //    {
    //        get
    //        { 
    //            return this.vertexCount; 
    //        }
    //    }
    //    public string this[int index] 
    //    {
    //        get 
    //        {
    //            if (index < 0 || index > this.vertexCount) throw new Exception("索引位置有错");
    //            return this.vertexList[index] == null ? "NULL" : this.vertexList[index].VertextName;
    //        }
    //        set 
    //        {
    //            if (index < 0 || index > this.vertexCount) throw new Exception("索引位置有错");
    //            if (this.vertexList[index] == null)
    //            {
    //                this.vertexList[index] = new VertexNode(value);
    //            }
    //            else 
    //            {
    //                this.vertexList[index].VertextName = value;
    //            }
    //        }
    //    }
    //    public AdGraph(int count) 
    //    {
    //        if (count < 0) throw new Exception("索引值传入有错");
    //        this.vertexCount = count;
    //        this.vertexList = new VertexNode[count];
    //    }
    //    private int GetIndex(string name) 
    //    {
    //        int i;
    //        for (i = 0; i < this.vertexCount; i++) 
    //        {
    //            if (this.vertexList[i] != null && this.vertexList[i].VertextName == name) 
    //            {
    //                break;
    //            }
    //        }
    //        return i == this.vertexCount ? -1 : i;
    //    }
    //    // 添加边
    //    private void AddEdge(string startName, string endName, double weight) 
    //    {
    //        int i = this.GetIndex(startName),
    //            j = this.GetIndex(endName);
    //        if (i == -1 || j == -1) 
    //        {
    //            throw new Exception("不存在这个的两个节点");
    //        }
    //        EdgeNode temp = this.vertexList[i].FirstNode;
    //        if (temp == null)
    //        {
    //            this.vertexList[i].FirstNode = new EdgeNode(j, weight);
    //        }
    //        else 
    //        {
    //            while (temp.Next != null) 
    //            {
    //                temp = temp.Next;
    //            }
    //            temp.Next = new EdgeNode(j, weight);
    //        }
    //    }
    //    // 深度优先搜索
    //    private void DFS(int i, ref string result) 
    //    {
    //        this.vertexList[i].Visited = true;
    //        result += this.vertexList[i].VertextName + "\n";
    //        EdgeNode temp = this.vertexList[i].FirstNode;
    //        while (temp != null) 
    //        {
    //            if (this.vertexList[temp.Index].Visited == true)
    //            {
    //                temp = temp.Next;
    //            }
    //            else 
    //            {
    //                this.DFS(temp.Index, ref result);
    //            }
    //        }
    //    }
    //    public string DFSTraversal(string startName) 
    //    {
    //        int i = this.GetIndex(startName);
    //        if (i == -1) throw new Exception("图中不存在该节点");
    //        string result = string.Empty;
    //        for (int j = 0; j < this.vertexCount; j++) 
    //        {
    //            this.vertexList[j].Visited = false;
    //        }
    //        this.DFS(i, ref result);
    //        return result;
    //    }
    //    // 广度优先搜索
    //    public string BFSTraversal(string startName)
    //    {
    //        int i = this.GetIndex(startName);
    //        if (i == -1) throw new Exception("图中不存在该节点");
    //        string result = string.Empty;
    //        LinkQueue<int> Q = new LinkQueue<int>();
    //        for (int j = 0; j < this.vertexCount; j++) 
    //        {
    //            this.vertexList[i].Visited = false;
    //        }
    //        this.vertexList[i].Visited = true;
    //        result += this.vertexList[i].VertextName + "\n";
    //        Q.EnQueue(i);
    //        while(Q.IsEmpty() == false) 
    //        {
    //            int k = Q.QueueFront;
    //            Q.DeQueue();
    //            EdgeNode temp = this.vertexList[k].FirstNode;
    //            while(temp != null) 
    //            {
    //                if (this.vertexList[temp.Index].Visited == false)
    //                {
    //                    this.vertexList[temp.Index].Visited = true;
    //                    result += this.vertexList[temp.Index].VertextName + "\n";
    //                    Q.EnQueue(temp.Index);
    //                }
    //                temp = temp.Next;
    //            }
    //        }
    //        return result;
    //    }
    //    // 拓扑排序
    //    // 返回所有顶点的入度
    //    private int[] GetDegressList() 
    //    {
    //        int[] result = new int[this.vertexCount];
    //        for (int i = 0; i < this.vertexCount; i++) 
    //        {
    //            EdgeNode temp = this.vertexList[i].FirstNode;
    //            while (temp != null) 
    //            {
    //                result[temp.Index]++;
    //                temp = temp.Next;
    //            }
    //        }
    //        return result;
    //    }
    //    public string TopoSort() 
    //    {
    //        string result = string.Empty;
    //        int[] ID = this.GetDegressList();
    //        LinkQueue<int> Q = new LinkQueue<int>();
    //        for (int i = 0; i < this.vertexCount; i++) 
    //        {
    //            if (ID[i] == 0) 
    //            {
    //                Q.EnQueue(i);
    //            }
    //        }
    //        if (Q.Length == this.vertexCount) throw new Exception("此有向图无有向边");
    //        while (Q.IsEmpty() == false) 
    //        {
    //            int j = Q.QueueFront;
    //            Q.DeQueue();
    //            result += this.vertexList[j].VertextName + "\n";
    //            EdgeNode temp = this.vertexList[j].FirstNode;
    //            while (temp != null) 
    //            {
    //                ID[temp.Index]--;
    //                if (ID[temp.Index] == 0) 
    //                {
    //                    Q.EnQueue(temp.Index);
    //                }
    //                temp = temp.Next;
    //            }
    //        }
    //        int k;
    //        for (k = 0; k < this.vertexCount; k++) 
    //        {
    //            if (ID[k] != 0) break;
    //        }
    //        return k == this.vertexCount ? result : "该AOV网中有环";
    //    }
    //}
}
