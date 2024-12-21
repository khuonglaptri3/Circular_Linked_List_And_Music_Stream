using Doubly_Linked_LIST;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib; 
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Circular_Linked_List_And_Music_Stream
{
    public partial class Music_Streaming_App : Form
    {
        private Circular_Linked_List playlist;
        private Node node; 
        OpenFileDialog openFileDialog; 
        public Music_Streaming_App()
        {
            InitializeComponent();
            
            playlist = new Circular_Linked_List();
   
            DisplaySongs();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplaySongs()
        {
            // Lấy danh sách các bài hát từ danh sách liên kết
            List<Song> songs = playlist.ToList();

            // Gán danh sách vào DataGridView
            dataGridViewSongs.DataSource = null; // Đặt null trước khi gán để làm mới dữ liệu
            dataGridViewSongs.DataSource = songs;
        }
        private void Music_Streaming_App_Load(object sender, EventArgs e)
        {
                
        }

        private void Addfile_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 Files|*.mp3";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.SafeFileName);  

                Song song = new Song(playlist.CreateId(), fileName, filePath);
                playlist.InsertAtTail(song);
                this.node = playlist.Head;
                DisplaySongs();
            }

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewSongs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BACKBUT_Click(object sender, EventArgs e)
        {
            if (this.node != null && this.node.Pprv != null)
            {
                this.node = this.node.Pprv;
                axWindowsMediaPlayer1.URL = this.node.data.FilePath;
                Song.Text = this.node.data.Title;
            }
            else
            {
                MessageBox.Show("No previous song available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void REPLAY_Click(object sender, EventArgs e)
        {
            if (this.node != null && this.node.Pprv != null)
            {
                axWindowsMediaPlayer1.URL = this.node.data.FilePath;
                Song.Text = this.node.data.Title;
            }
            else
            {
                MessageBox.Show("No song. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NEXTBUT_Click(object sender, EventArgs e)
        {
            if (this.node != null && this.node.Pprv != null)
            {
                this.node = this.node.Pnext;
                axWindowsMediaPlayer1.URL = this.node.data.FilePath;
                Song.Text = this.node.data.Title;
            }
            else
            {
                MessageBox.Show("No next song available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Shuffle_Click(object sender, EventArgs e)
        {
            playlist.Shuffle();
            DisplaySongs();
        }

        private void SORT_Click(object sender, EventArgs e)
        {
            playlist.SelectionSort(); 
            DisplaySongs(); 
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            playlist.Reverse();
            DisplaySongs();  
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idtxt.Text))
            {
                playlist.DeleteAtHead();
                if (!playlist.IsEmpty())
                {
                    MessageBox.Show("Song deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("No song to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.node = playlist.Head;
                }
                DisplaySongs();
            }
            else
            {
                int id;
                if (int.TryParse(idtxt.Text, out id))
                {
                    if (playlist.SearchById(id) == null)
                    {
                        MessageBox.Show("Song not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        playlist.DeleteById(id);
                        MessageBox.Show("Song deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplaySongs();
                        this.node = playlist.Head;   
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void DELETE_SONG_BY_ID_Click(object sender, EventArgs e)
        {

        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            int keyword = int.Parse(SEARCH.Text.Trim().ToLower());
            List<Song> matchingNodes = new List<Song>(); 
            matchingNodes.Add(playlist.SearchById(keyword));

            if (matchingNodes.Count == 0)
            {
                MessageBox.Show("No matching song found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Song> matchingSongs = matchingNodes.Select(node => node.data).ToList();
                dataGridViewSongs.DataSource = null;
                dataGridViewSongs.DataSource = matchingSongs;
            }
        }
    }
}
