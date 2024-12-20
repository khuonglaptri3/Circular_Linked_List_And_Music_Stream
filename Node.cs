using Circular_Linked_List_And_Music_Stream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_LIST
{
    public class Node
    {
        private Song Data; // Data of the node   
        private Node pnext;
        private Node pprv;
        public Node()
        {
            this.data = default ;
            this.pnext = null;
            this.pprv = null;
        }
        public Node(Song info)
        {
            this.data = info;
            this.pnext = null;
            this.pprv = null;
        }
        public Song data
        {
            get { return this.Data; }
            set { this.Data = value; }
        }
        public Node Pnext
        {
            get { return pnext; }
            set { pnext = value; }
        }
        public Node Pprv
        {
            get { return pprv; }
            set { pprv = value; }
        }
    }
}
