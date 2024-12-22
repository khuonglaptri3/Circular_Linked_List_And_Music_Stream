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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music_Streaming_App));
            this.Addfile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Delete = new Guna.UI2.WinForms.Guna2Button();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DELETE_SONG_BY_ID = new System.Windows.Forms.Label();
            this.dataGridViewSongs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.I = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BACKBUT = new Guna.UI2.WinForms.Guna2Button();
            this.NEXTBUT = new Guna.UI2.WinForms.Guna2Button();
            this.Song = new System.Windows.Forms.Label();
            this.REPLAY = new Guna.UI2.WinForms.Guna2Button();
            this.Shuffle = new Guna.UI2.WinForms.Guna2Button();
            this.SORT = new Guna.UI2.WinForms.Guna2Button();
            this.REVERSE = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Idtx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SEARCH = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CLEAR = new Guna.UI2.WinForms.Guna2Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSongs)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Addfile
            // 
            this.Addfile.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold);
            this.Addfile.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Addfile.Location = new System.Drawing.Point(3, 3);
            this.Addfile.Name = "Addfile";
            this.Addfile.Size = new System.Drawing.Size(146, 42);
            this.Addfile.TabIndex = 2;
            this.Addfile.Text = "Add_Song";
            this.Addfile.UseVisualStyleBackColor = true;
            this.Addfile.Click += new System.EventHandler(this.Addfile_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.idtxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DELETE_SONG_BY_ID);
            this.panel1.Location = new System.Drawing.Point(12, 483);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 155);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Delete
            // 
            this.Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(233, 119);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(105, 46);
            this.Delete.TabIndex = 20;
            this.Delete.Text = "DELETE";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // idtxt
            // 
            this.idtxt.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold);
            this.idtxt.Location = new System.Drawing.Point(62, 59);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(85, 32);
            this.idtxt.TabIndex = 11;
            this.idtxt.TextChanged += new System.EventHandler(this.idtxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // DELETE_SONG_BY_ID
            // 
            this.DELETE_SONG_BY_ID.AutoSize = true;
            this.DELETE_SONG_BY_ID.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold);
            this.DELETE_SONG_BY_ID.Location = new System.Drawing.Point(3, 10);
            this.DELETE_SONG_BY_ID.Name = "DELETE_SONG_BY_ID";
            this.DELETE_SONG_BY_ID.Size = new System.Drawing.Size(149, 26);
            this.DELETE_SONG_BY_ID.TabIndex = 9;
            this.DELETE_SONG_BY_ID.Text = "DELETE_SONG";
            this.DELETE_SONG_BY_ID.Click += new System.EventHandler(this.DELETE_SONG_BY_ID_Click);
            // 
            // dataGridViewSongs
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridViewSongs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSongs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSongs.ColumnHeadersHeight = 4;
            this.dataGridViewSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSongs.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSongs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewSongs.Location = new System.Drawing.Point(1, 40);
            this.dataGridViewSongs.Name = "dataGridViewSongs";
            this.dataGridViewSongs.RowHeadersVisible = false;
            this.dataGridViewSongs.RowHeadersWidth = 51;
            this.dataGridViewSongs.RowTemplate.Height = 24;
            this.dataGridViewSongs.Size = new System.Drawing.Size(1088, 217);
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
            this.BACKBUT.Location = new System.Drawing.Point(327, 285);
            this.BACKBUT.Name = "BACKBUT";
            this.BACKBUT.Size = new System.Drawing.Size(105, 46);
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
            this.NEXTBUT.Location = new System.Drawing.Point(776, 285);
            this.NEXTBUT.Name = "NEXTBUT";
            this.NEXTBUT.Size = new System.Drawing.Size(105, 46);
            this.NEXTBUT.TabIndex = 13;
            this.NEXTBUT.Text = "NEXT";
            this.NEXTBUT.Click += new System.EventHandler(this.NEXTBUT_Click);
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
            // REPLAY
            // 
            this.REPLAY.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.REPLAY.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.REPLAY.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.REPLAY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.REPLAY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.REPLAY.ForeColor = System.Drawing.Color.White;
            this.REPLAY.Location = new System.Drawing.Point(122, 285);
            this.REPLAY.Name = "REPLAY";
            this.REPLAY.Size = new System.Drawing.Size(105, 46);
            this.REPLAY.TabIndex = 16;
            this.REPLAY.Text = "REPLAY";
            this.REPLAY.Click += new System.EventHandler(this.REPLAY_Click);
            // 
            // Shuffle
            // 
            this.Shuffle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Shuffle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Shuffle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Shuffle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Shuffle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Shuffle.ForeColor = System.Drawing.Color.White;
            this.Shuffle.Location = new System.Drawing.Point(1103, 40);
            this.Shuffle.Name = "Shuffle";
            this.Shuffle.Size = new System.Drawing.Size(105, 46);
            this.Shuffle.TabIndex = 17;
            this.Shuffle.Text = "Shuffle";
            this.Shuffle.Click += new System.EventHandler(this.Shuffle_Click);
            // 
            // SORT
            // 
            this.SORT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SORT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SORT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SORT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SORT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SORT.ForeColor = System.Drawing.Color.White;
            this.SORT.Location = new System.Drawing.Point(1103, 117);
            this.SORT.Name = "SORT";
            this.SORT.Size = new System.Drawing.Size(105, 46);
            this.SORT.TabIndex = 18;
            this.SORT.Text = "SORT WITH ID";
            this.SORT.Click += new System.EventHandler(this.SORT_Click);
            // 
            // REVERSE
            // 
            this.REVERSE.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.REVERSE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.REVERSE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.REVERSE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.REVERSE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.REVERSE.ForeColor = System.Drawing.Color.White;
            this.REVERSE.Location = new System.Drawing.Point(1103, 199);
            this.REVERSE.Name = "REVERSE";
            this.REVERSE.Size = new System.Drawing.Size(105, 46);
            this.REVERSE.TabIndex = 19;
            this.REVERSE.Text = "REVERSE";
            this.REVERSE.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.Addfile);
            this.panel2.Location = new System.Drawing.Point(1085, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 53);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Controls.Add(this.Idtx);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.SEARCH);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(421, 483);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 155);
            this.panel3.TabIndex = 21;
            // 
            // Idtx
            // 
            this.Idtx.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold);
            this.Idtx.Location = new System.Drawing.Point(104, 56);
            this.Idtx.Name = "Idtx";
            this.Idtx.Size = new System.Drawing.Size(243, 32);
            this.Idtx.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(15, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 26);
            this.label4.TabIndex = 21;
            this.label4.Text = "ID:";
            // 
            // SEARCH
            // 
            this.SEARCH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SEARCH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SEARCH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SEARCH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SEARCH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SEARCH.ForeColor = System.Drawing.Color.White;
            this.SEARCH.Location = new System.Drawing.Point(233, 119);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(105, 36);
            this.SEARCH.TabIndex = 20;
            this.SEARCH.Text = "SEARCH";
            this.SEARCH.Click += new System.EventHandler(this.SEARCH_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "SEARCH_WITH_ID";
            // 
            // CLEAR
            // 
            this.CLEAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CLEAR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CLEAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CLEAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CLEAR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CLEAR.ForeColor = System.Drawing.Color.White;
            this.CLEAR.Location = new System.Drawing.Point(1184, 592);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(105, 46);
            this.CLEAR.TabIndex = 22;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(336, 230);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(233, 48);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // Music_Streaming_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 665);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.REVERSE);
            this.Controls.Add(this.SORT);
            this.Controls.Add(this.Shuffle);
            this.Controls.Add(this.REPLAY);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.Song);
            this.Controls.Add(this.NEXTBUT);
            this.Controls.Add(this.BACKBUT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.I);
            this.Controls.Add(this.dataGridViewSongs);
            this.Controls.Add(this.panel1);
            this.Name = "Music_Streaming_App";
            this.Text = "Music_Streaming_App";
            this.Load += new System.EventHandler(this.Music_Streaming_App_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSongs)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button Addfile;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewSongs;
        private System.Windows.Forms.Label I;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button BACKBUT;
        private Guna.UI2.WinForms.Guna2Button NEXTBUT;
        private System.Windows.Forms.Label Song;
        private Guna.UI2.WinForms.Guna2Button REPLAY;
        private Guna.UI2.WinForms.Guna2Button Shuffle;
        private Guna.UI2.WinForms.Guna2Button SORT;
        private Guna.UI2.WinForms.Guna2Button REVERSE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DELETE_SONG_BY_ID;
        private System.Windows.Forms.TextBox idtxt;
        private Guna.UI2.WinForms.Guna2Button Delete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button SEARCH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Idtx;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button CLEAR;
    }
}