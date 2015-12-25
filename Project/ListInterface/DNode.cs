using System;
using System.Collections.Generic;
using System.Text;

namespace DnodeClass
{
    public class Dnode<T>
    {
        private T data;
        private Dnode<T> next;
        private Dnode<T> prior;
        public T Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.Data = value;
            }
        }
        public Dnode<T> Next
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
        public Dnode<T> Prior
        {
            get
            {
                return this.prior;
            }
            set
            {
                this.prior = value;
            }
        }
        public Dnode(T data)
        {
            this.data = data;
        }
        public Dnode(Dnode<T> prior, T data, Dnode<T> next)
        {
            this.data = data;
            this.prior = prior;
            this.next = next;
        }
    }
}
