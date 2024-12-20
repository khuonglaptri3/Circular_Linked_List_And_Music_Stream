using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Linked_List_And_Music_Stream
{
    public class Song
    {
        private int id;
        private  string title;
        private string filePath;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }   
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public Song() { } // default constructor
        public Song(int id, string title, string filePath)
        {
            Id = id;
            Title = title;
            FilePath = filePath;
       
        }
    }
}
