﻿using Doubly_Linked_LIST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Circular_Linked_List_And_Music_Stream
{
    public  class Circular_Linked_List
    {
        private Node head;
        // constructor to create an empty circular linked list
        public Node Head
        {
            get { return head; }
            set { head = value; }
        }   
        public Circular_Linked_List()
        {
            head = null;
        }
        // 	Create a new node 
        public Node CreateNode(Song Data)
        {

            return new Node(Data); // create a new node with the given data  
        }
        //  Check if the node is empty    
        public bool IsNodeEmpty(Node node)
        {
            return node == null;
        }
        // check if the list is empty    
        public bool IsEmpty()
        {
            return head == null;
        }
        // 	Insert a new node at the beginning of the list 
        public void InsertAtHead(Song data)
        {
            Node newNode = CreateNode(data);

            if (IsEmpty())
            {
                newNode.Pnext = newNode;
                newNode.Pprv = newNode;
                head = newNode;
            }
            else
            {
                Node tail = head.Pprv;
                newNode.Pnext = head;
                newNode.Pprv = tail;
                head.Pprv = newNode;
                tail.Pnext = newNode;
                head = newNode;
            }
        }
        // 	Insert a new node at the end of the list    

        public void InsertAtTail(Song data)
        {
            Node newNode = CreateNode(data);

            if (IsEmpty())
            {
                InsertAtHead(data);
            }
            else
            {
                Node tail = head.Pprv;
                newNode.Pnext = head;
                newNode.Pprv = tail;
                tail.Pnext = newNode;
                head.Pprv = newNode;
            }
        }
        //	Insert a new node after a node of the list
        public void InsertAfter(Node current, Song data)
        {
            if (IsNodeEmpty(current) == true )
                throw new ArgumentNullException("current", "Node cannot be null.");

            Node newNode = CreateNode(data);
            Node nextNode = current.Pnext;

            newNode.Pnext = nextNode;
            newNode.Pprv = current;
            current.Pnext = newNode;
            nextNode.Pprv = newNode;
        }
        // 	Remove the first node of the list 
        public void RemoveHead()
        {
            if (IsEmpty())
                throw new InvalidOperationException("List is empty.");

            Node tail = head.Pprv;
            Node nextNode = head.Pnext;

            tail.Pnext = nextNode;
            nextNode.Pprv = tail;
            head = nextNode;
        }
        // 	Remove the first node of the list 
        public void DeleteAtHead()
        {
            if (IsEmpty()) return;

            if (head.Pnext == head)
            {
                head = null;
            }
            else
            {
                Node tail = head.Pprv;
                head = head.Pnext;
                head.Pprv = tail;
                tail.Pnext = head;
            }
        }
        //   Remove the last node of the list 
        public void DeleteAtTail()
        {
            if (IsEmpty()) return;

            if (head.Pnext == head)
            {
                head = null;
            }
            else
            {
                Node tail = head.Pprv;
                Node newTail = tail.Pprv;
                newTail.Pnext = head;
                head.Pprv = newTail;
            }
        }
        //   Remove a node after a node of the list 
        public void DeleteAfter(Node current)
        {
            if (IsEmpty() || current == null) return;

            Node nodeToDelete = current.Pnext;
            if (nodeToDelete == head)
            {
                DeleteAtHead();
            }
            else
            {
                Node nextNode = nodeToDelete.Pnext;
                current.Pnext = nextNode;
                nextNode.Pprv = current;
            }
        }
        // Search a node in the list 
        public Node Search(int id)
        {
            if (IsEmpty()) return null;

            Node current = head;
            do
            {
                if (current.data.Id == id)
                    return current;
                current = current.Pnext;
            } while (current != head);

            return null;
        }
        //	Search nodes in the list satisfying a specific criteria
        public List<Node> SearchByCriteria(Func<Song, bool> criteria)
        {
            List<Node> results = new List<Node>();

            if (IsEmpty()) return results;

            Node current = head;
            do
            {
                if (criteria(current.data))
                    results.Add(current);
                current = current.Pnext;
            } while (current != head);

            return results;
        }
        // 	Display the list     
        public void PrintList()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Danh sách rỗng.");
                return;
            }

            Node current = head;
            do
            {
                Console.WriteLine(current.data.ToString());
                current = current.Pnext;
            } while (current != head);
        }
        // Selection Sort the list   
        public void SelectionSort()
        {
            if (IsEmpty()) return;

            Node current = head;
            do
            {
                Node min = current;
                Node next = current.Pnext;
                while (next != head)
                {
                    if (next.data.Id < min.data.Id)
                        min = next;
                    next = next.Pnext;
                }

                if (min != current)
                {
                    Song temp = current.data;
                    current.data = min.data;
                    min.data = temp;
                }

                current = current.Pnext;
            } while (current.Pnext != head);
        }
        // Quick Sort the list   
        public void QuickSort()
        {
            if (IsEmpty()) return;
            head = QuickSortRecursive(head, head.Pprv);
        }

        private Node QuickSortRecursive(Node start, Node end)
        {
            if (start == end || start == null || end == null)
                return start;

            Node pivotPrev = Partition(start, end, out Node newPivot);

            if (pivotPrev != null)
                QuickSortRecursive(start, pivotPrev);

            if (newPivot != null && newPivot.Pnext != null)
                QuickSortRecursive(newPivot.Pnext, end);

            return head;
        }

        private Node Partition(Node start, Node end, out Node pivot)
        {
            pivot = end;
            Node pivotPrev = null;
            Node current = start;
            Node tail = pivot.Pprv;

            while (current != pivot)
            {
                if (current.data.Id < pivot.data.Id)
                {
                    if (pivotPrev == null)
                        pivotPrev = start;
                    else
                        pivotPrev = pivotPrev.Pnext;
                }
                else
                {
                    Swap(current.data, pivot.data);
                }

                current = current.Pnext;
            }

            return pivotPrev;
        }
        private void Swap(Song a, Song b)
        {
            Song temp = a;
            a = b;
            b = temp;
        }
        // Propose at least 3 operations on the list (Example: Merge two lists, remove all nodes satisfying a specific criteria) 
        // 1.  Merge two song lists
        public void Merge(Circular_Linked_List other)
        {
            if (other == null || other.IsEmpty()) return;
            if (this.IsEmpty())
            {
                this.head = other.head;
                return;
            }

            Node tail1 = this.head.Pprv;
            Node tail2 = other.head.Pprv;

            tail1.Pnext = other.head;
            other.head.Pprv = tail1;
            tail2.Pnext = this.head;
            this.head.Pprv = tail2;
        }
        // 2. Remove all nodes satisfying a specific criteria   
        public void DeleteByCriteria(Func<Song, bool> criteria)
        {
            if (IsEmpty()) return;

            Node current = head;
            do
            {
                Node next = current.Pnext;
                if (criteria(current.data))
                {
                    if (current == head)
                        DeleteAtHead();
                    else
                        DeleteAfter(current.Pprv);
                }

                current = next;
            } while (current != head);
        }
        // 3. Reverse the list   
        public void Reverse()
        {
            if (IsEmpty()) return;

            Node current = head;
            Node prev = null;
            Node next;

            do
            {
                next = current.Pnext;
                current.Pnext = prev;
                current.Pprv = next;
                prev = current;
                current = next;
            } while (current != head);

            head.Pprv = prev;
            head = prev;
        }
        // Creat the  Id of the song 
        public int CreateId()
        {
            if (IsEmpty()) return 1;

            Node current = head;
            int maxId = current.data.Id;
            do
            {
                if (current.data.Id > maxId)
                    maxId = current.data.Id;
                current = current.Pnext;
            } while (current != head);

            return maxId + 1;
        }

        // 4. convert the Linked  to a list of songs to display in the DataGridView     
        public List<Song> ToList()
        {
            List<Song> songs = new List<Song>();
            if (IsEmpty()) return songs;

            Node current = head;
            do
            {
                songs.Add(current.data);
                current = current.Pnext;
            } while (current != head);

            return songs;
        }
    }
}