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
            string keyword = Idtx.Text.Trim();

            // Check if the keyword is an integer (for ID search)
            if (int.TryParse(keyword, out int id))
            {
                Song result = playlist.SearchById(id);
                if (result != null)
                {
                    dataGridViewSongs.DataSource = new List<Song> { result };
                    axWindowsMediaPlayer1.URL = result.FilePath;
                    Song.Text = result.Title;   

                }
                else
                {
                    MessageBox.Show("No matching song found by ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Search by title
                List<Node> matchingNodes = playlist.SearchByCriteria(song =>
                    song.Title.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0
                );

                if (matchingNodes.Count == 0)
                {
                    MessageBox.Show("No matching song found by title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    List<Song> matchingSongs = matchingNodes.Select(node => node.data).ToList();
                    dataGridViewSongs.DataSource = matchingSongs; 
                    axWindowsMediaPlayer1.URL = matchingNodes[0].data.FilePath;
                    Song.Text = matchingNodes[0].data.Title;

                }
            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
          DisplaySongs();   
        }
    }
}
