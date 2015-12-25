using System;
using System.Collections.Generic;
using System.Text;

namespace SNodeClass
{
    public class SNode<T>
    {
        private T data;
        private SNode<T> next;

        public T Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }

        public SNode<T> Next
        {
            get
            {
                return this.next;
            }
            set
            {
                this.next = value;
            }
        }

        public SNode(T data)
        {
            this.data = data;
            this.next = null;
        }
        public SNode(T data, SNode<T> next)
        {
            this.data = data;
            this.next = next;
        }
    }
}
