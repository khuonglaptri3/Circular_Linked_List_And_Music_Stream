namespace Circular_Linked_List_And_Music_Stream
{
    partial class Music_Streaming_App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music_Streaming_App));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Addfile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.dataGridViewSongs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.I = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BACKBUT = new Guna.UI2.WinForms.Guna2Button();
            this.NEXTBUT = new Guna.UI2.WinForms.Guna2Button();
            this.Song = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSongs)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Addfile
            // 
            this.Addfile.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Addfile.Location = new System.Drawing.Point(291, 64);
            this.Addfile.Name = "Addfile";
            this.Addfile.Size = new System.Drawing.Size(75, 23);
            this.Addfile.TabIndex = 2;
            this.Addfile.Text = "...";
            this.Addfile.UseVisualStyleBackColor = true;
            this.Addfile.Click += new System.EventHandler(this.Addfile_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Addfile);
            this.panel1.Location = new System.Drawing.Point(812, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 237);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(82, 39);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(37, 37);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // dataGridViewSongs
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewSongs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSongs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSongs.ColumnHeadersHeight = 4;
            this.dataGridViewSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSongs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSongs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewSongs.Location = new System.Drawing.Point(1, 40);
            this.dataGridViewSongs.Name = "dataGridViewSongs";
            this.dataGridViewSongs.RowHeadersVisible = false;
            this.dataGridViewSongs.RowHeadersWidth = 51;
            this.dataGridViewSongs.RowTemplate.Height = 24;
            this.dataGridViewSongs.Size = new System.Drawing.Size(1288, 217);
            this.dataGridViewSongs.TabIndex = 5;
            this.dataGridViewSongs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewSongs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewSongs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewSongs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewSongs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewSongs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewSongs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewSongs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewSongs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewSongs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewSongs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewSongs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewSongs.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridViewSongs.ThemeStyle.ReadOnly = false;
            this.dataGridViewSongs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewSongs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewSongs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewSongs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewSongs.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewSongs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewSongs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewSongs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSongs_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel2.Location = new System.Drawing.Point(509, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 6;
            // 
            // I
            // 
            this.I.AutoSize = true;
            this.I.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I.Location = new System.Drawing.Point(-5, 6);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(40, 31);
            this.I.TabIndex = 7;
            this.I.Text = "ID";
            this.I.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(415, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(836, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Songs_File_Path";
            // 
            // BACKBUT
            // 
            this.BACKBUT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BACKBUT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BACKBUT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BACKBUT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BACKBUT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BACKBUT.ForeColor = System.Drawing.Color.White;
            this.BACKBUT.Location = new System.Drawing.Point(452, 285);
            this.BACKBUT.Name = "BACKBUT";
            this.BACKBUT.Size = new System.Drawing.Size(105, 35);
            this.BACKBUT.TabIndex = 12;
            this.BACKBUT.Text = "BACK";
            this.BACKBUT.Click += new System.EventHandler(this.BACKBUT_Click);
            // 
            // NEXTBUT
            // 
            this.NEXTBUT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NEXTBUT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NEXTBUT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NEXTBUT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NEXTBUT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NEXTBUT.ForeColor = System.Drawing.Color.White;
            this.NEXTBUT.Location = new System.Drawing.Point(715, 285);
            this.NEXTBUT.Name = "NEXTBUT";
            this.NEXTBUT.Size = new System.Drawing.Size(105, 35);
            this.NEXTBUT.TabIndex = 13;
            this.NEXTBUT.Text = "NEXT";
            // 
            // Song
            // 
            this.Song.AutoSize = true;
            this.Song.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.Song.Location = new System.Drawing.Point(521, 353);
            this.Song.Name = "Song";
            this.Song.Size = new System.Drawing.Size(0, 31);
            this.Song.TabIndex = 15;
            // 
            // Music_Streaming_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 665);
            this.Controls.Add(this.Song);
            this.Controls.Add(this.NEXTBUT);
            this.Controls.Add(this.BACKBUT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.I);
            this.Controls.Add(this.dataGridViewSongs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Music_Streaming_App";
            this.Text = "Music_Streaming_App";
            this.Load += new System.EventHandler(this.Music_Streaming_App_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSongs)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button Addfile;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewSongs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label I;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button BACKBUT;
        private Guna.UI2.WinForms.Guna2Button NEXTBUT;
        private System.Windows.Forms.Label Song;
    }
}