
namespace İcerisiSampiyonsLigi
{
    partial class OyunPlanı
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyunPlanı));
            this.btnListele = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pbo4 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pbo1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pbo2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pbo3 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbo5 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pbo6 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pbo7 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pbo8 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pbo9 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pbo10 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pbo11 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.playerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mevkii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbo3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbo5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbo6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbo7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbo8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbo9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbo10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbo11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(159, 12);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(164, 23);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "OYUN PLANINI GÖRÜNTÜLE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerNameDataGridViewTextBoxColumn,
            this.Mevkii,
            this.resimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.playerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(428, 504);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // pbo4
            // 
            this.pbo4.AllowFocused = false;
            this.pbo4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbo4.AutoSizeHeight = true;
            this.pbo4.BorderRadius = 35;
            this.pbo4.Image = ((System.Drawing.Image)(resources.GetObject("pbo4.Image")));
            this.pbo4.IsCircle = true;
            this.pbo4.Location = new System.Drawing.Point(231, 383);
            this.pbo4.Name = "pbo4";
            this.pbo4.Size = new System.Drawing.Size(70, 70);
            this.pbo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbo4.TabIndex = 6;
            this.pbo4.TabStop = false;
            this.pbo4.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // pbo1
            // 
            this.pbo1.AllowFocused = false;
            this.pbo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbo1.AutoSizeHeight = true;
            this.pbo1.BorderRadius = 35;
            this.pbo1.Image = ((System.Drawing.Image)(resources.GetObject("pbo1.Image")));
            this.pbo1.IsCircle = true;
            this.pbo1.Location = new System.Drawing.Point(179, 472);
            this.pbo1.Name = "pbo1";
            this.pbo1.Size = new System.Drawing.Size(70, 70);
            this.pbo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbo1.TabIndex = 6;
            this.pbo1.TabStop = false;
            this.pbo1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // pbo2
            // 
            this.pbo2.AllowFocused = false;
            this.pbo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbo2.AutoSizeHeight = true;
            this.pbo2.BorderRadius = 31;
            this.pbo2.Image = ((System.Drawing.Image)(resources.GetObject("pbo2.Image")));
            this.pbo2.IsCircle = true;
            this.pbo2.Location = new System.Drawing.Point(43, 387);
            this.pbo2.Name = "pbo2";
            this.pbo2.Size = new System.Drawing.Size(62, 62);
            this.pbo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbo2.TabIndex = 6;
            this.pbo2.TabStop = false;
            this.pbo2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // pbo3
            // 
            this.pbo3.AllowFocused = false;
            this.pbo3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbo3.AutoSizeHeight = true;
            this.pbo3.BorderRadius = 35;
            this.pbo3.Image = ((System.Drawing.Image)(resources.GetObject("pbo3.Image")));
            this.pbo3.IsCircle = true;
            this.pbo3.Location = new System.Drawing.Point(129, 383);
            this.pbo3.Name = "pbo3";
            this.pbo3.Size = new System.Drawing.Size(70, 70);
            this.pbo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbo3.TabIndex = 6;
            this.pbo3.TabStop = false;
            this.pbo3.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pbo1);
            this.panel1.Controls.Add(this.pbo9);
            this.panel1.Controls.Add(this.pbo11);
            this.panel1.Controls.Add(this.pbo8);
            this.panel1.Controls.Add(this.pbo10);
            this.panel1.Controls.Add(this.pbo5);
            this.panel1.Controls.Add(this.pbo7);
            this.panel1.Controls.Add(this.pbo4);
            this.panel1.Controls.Add(this.pbo6);
            this.panel1.Controls.Add(this.pbo3);
            this.panel1.Controls.Add(this.pbo2);
            this.panel1.Location = new System.Drawing.Point(446, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 552);
            this.panel1.TabIndex = 7;
            // 
            // pbo5
            // 
            this.pbo5.AllowFocused = false;
            this.pbo5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbo5.AutoSizeHeight = true;
            this.pbo5.BorderRadius = 35;
            this.pbo5.Image = ((System.Drawing.Image)(resources.GetObject("pbo5.Image")));
            this.pbo5.IsCircle = true;
            this.pbo5.Location = new System.Drawing.Point(335, 383);
            this.pbo5.Name = "pbo5";
            this.pbo5.Size = new System.Drawing.Size(70, 70);
            this.pbo5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbo5.TabIndex = 6;
            this.pbo5.TabStop = false;
            this.pbo5.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // pbo6
            // 
            this.pbo6.AllowFocused = false;
            this.pbo6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbo6.AutoSizeHeight = true;
            this.pbo6.BorderRadius = 31;
            this.pbo6.Image = ((System.Drawing.Image)(resources.GetObject("pbo6.Image")));
            this.pbo6.IsCircle = true;
            this.pbo6.Location = new System.Drawing.Point(43, 247);
            this.pbo6.Name = "pbo6";
            this.pbo6.Size = new System.Drawing.Size(62, 62);
            this.pbo6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbo6.TabIndex = 6;
            this.pbo6.TabStop = false;
            this.pbo6.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // pbo7
            // 
            this.pbo7.AllowFocused = false;
            this.pbo7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbo7.AutoSizeHeight = true;
            this.pbo7.BorderRadius = 35;
            this.pbo7.Image = ((System.Drawing.Image)(resources.GetObject("pbo7.Image")));
            this.pbo7.IsCircle = true;
            this.pbo7.Location = new System.Drawing.Point(129, 243);
            this.pbo7.Name = "pbo7";
            this.pbo7.Size = new System.Drawing.Size(70, 70);
            this.pbo7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbo7.TabIndex = 6;
            this.pbo7.TabStop = false;
            this.pbo7.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // pbo8
            // 
            this.pbo8.AllowFocused = false;
            this.pbo8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbo8.AutoSizeHeight = true;
            this.pbo8.BorderRadius = 35;
            this.pbo8.Image = ((System.Drawing.Image)(resources.GetObject("pbo8.Image")));
            this.pbo8.IsCircle = true;
            this.pbo8.Location = new System.Drawing.Point(231, 243);
            this.pbo8.Name = "pbo8";
            this.pbo8.Size = new System.Drawing.Size(70, 70);
            this.pbo8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbo8.TabIndex = 6;
            this.pbo8.TabStop = false;
            this.pbo8.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // pbo9
            // 
            this.pbo9.AllowFocused = false;
            this.pbo9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbo9.AutoSizeHeight = true;
            this.pbo9.BorderRadius = 35;
            this.pbo9.Image = ((System.Drawing.Image)(resources.GetObject("pbo9.Image")));
            this.pbo9.IsCircle = true;
            this.pbo9.Location = new System.Drawing.Point(335, 243);
            this.pbo9.Name = "pbo9";
            this.pbo9.Size = new System.Drawing.Size(70, 70);
            this.pbo9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbo9.TabIndex = 6;
            this.pbo9.TabStop = false;
            this.pbo9.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // pbo10
            // 
            this.pbo10.AllowFocused = false;
            this.pbo10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbo10.AutoSizeHeight = true;
            this.pbo10.BorderRadius = 35;
            this.pbo10.Image = ((System.Drawing.Image)(resources.GetObject("pbo10.Image")));
            this.pbo10.IsCircle = true;
            this.pbo10.Location = new System.Drawing.Point(129, 104);
            this.pbo10.Name = "pbo10";
            this.pbo10.Size = new System.Drawing.Size(70, 70);
            this.pbo10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbo10.TabIndex = 6;
            this.pbo10.TabStop = false;
            this.pbo10.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // pbo11
            // 
            this.pbo11.AllowFocused = false;
            this.pbo11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbo11.AutoSizeHeight = true;
            this.pbo11.BorderRadius = 35;
            this.pbo11.Image = ((System.Drawing.Image)(resources.GetObject("pbo11.Image")));
            this.pbo11.IsCircle = true;
            this.pbo11.Location = new System.Drawing.Point(231, 104);
            this.pbo11.Name = "pbo11";
            this.pbo11.Size = new System.Drawing.Size(70, 70);
            this.pbo11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbo11.TabIndex = 6;
            this.pbo11.TabStop = false;
            this.pbo11.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // playerNameDataGridViewTextBoxColumn
            // 
            this.playerNameDataGridViewTextBoxColumn.DataPropertyName = "PlayerName";
            this.playerNameDataGridViewTextBoxColumn.HeaderText = "Oyuncu adı";
            this.playerNameDataGridViewTextBoxColumn.Name = "playerNameDataGridViewTextBoxColumn";
            this.playerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Mevkii
            // 
            this.Mevkii.DataPropertyName = "Mevkii";
            this.Mevkii.HeaderText = "Mevkii";
            this.Mevkii.Name = "Mevkii";
            this.Mevkii.ReadOnly = true;
            // 
            // resimDataGridViewTextBoxColumn
            // 
            this.resimDataGridViewTextBoxColumn.DataPropertyName = "Resim";
            this.resimDataGridViewTextBoxColumn.HeaderText = "Resim";
            this.resimDataGridViewTextBoxColumn.Name = "resimDataGridViewTextBoxColumn";
            this.resimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(İcerisiSampiyonsLigi.Models.Player);
            // 
            // OyunPlanı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnListele);
            this.Name = "OyunPlanı";
            this.Text = "OyunPlanı";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbo3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbo5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbo6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbo7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbo8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbo9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbo10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbo11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.UI.WinForms.BunifuPictureBox pbo4;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mevkii;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private Bunifu.UI.WinForms.BunifuPictureBox pbo1;
        private Bunifu.UI.WinForms.BunifuPictureBox pbo2;
        private Bunifu.UI.WinForms.BunifuPictureBox pbo3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuPictureBox pbo9;
        private Bunifu.UI.WinForms.BunifuPictureBox pbo11;
        private Bunifu.UI.WinForms.BunifuPictureBox pbo8;
        private Bunifu.UI.WinForms.BunifuPictureBox pbo10;
        private Bunifu.UI.WinForms.BunifuPictureBox pbo5;
        private Bunifu.UI.WinForms.BunifuPictureBox pbo7;
        private Bunifu.UI.WinForms.BunifuPictureBox pbo6;
    }
}