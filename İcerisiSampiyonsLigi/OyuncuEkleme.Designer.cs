
namespace İcerisiSampiyonsLigi
{
    partial class OyuncuEkleme
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
            this.txtOyuncuAdi = new System.Windows.Forms.TextBox();
            this.lblAnaMenu = new System.Windows.Forms.LinkLabel();
            this.btnOyunucEkle = new System.Windows.Forms.Button();
            this.txtmevkii = new System.Windows.Forms.TextBox();
            this.cmbTakimlar = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.txtduzMevki = new System.Windows.Forms.TextBox();
            this.cmbDuzTakım = new System.Windows.Forms.ComboBox();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.txtResim = new System.Windows.Forms.TextBox();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.txtDuzResim = new System.Windows.Forms.TextBox();
            this.txtdüzOyuncuAd = new System.Windows.Forms.TextBox();
            this.btnOyuncuDuzenle = new System.Windows.Forms.Button();
            this.dgvOyuncular = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.playerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mevkiiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerTeamNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOyuncular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOyuncuAdi
            // 
            this.txtOyuncuAdi.Location = new System.Drawing.Point(150, 240);
            this.txtOyuncuAdi.Name = "txtOyuncuAdi";
            this.txtOyuncuAdi.Size = new System.Drawing.Size(121, 20);
            this.txtOyuncuAdi.TabIndex = 0;
            // 
            // lblAnaMenu
            // 
            this.lblAnaMenu.AutoSize = true;
            this.lblAnaMenu.Location = new System.Drawing.Point(12, 428);
            this.lblAnaMenu.Name = "lblAnaMenu";
            this.lblAnaMenu.Size = new System.Drawing.Size(93, 13);
            this.lblAnaMenu.TabIndex = 17;
            this.lblAnaMenu.TabStop = true;
            this.lblAnaMenu.Text = "Ana Menüye Dön ";
            this.lblAnaMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAnaMenu_LinkClicked);
            // 
            // btnOyunucEkle
            // 
            this.btnOyunucEkle.BackColor = System.Drawing.Color.Brown;
            this.btnOyunucEkle.FlatAppearance.BorderSize = 0;
            this.btnOyunucEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOyunucEkle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOyunucEkle.Location = new System.Drawing.Point(187, 360);
            this.btnOyunucEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnOyunucEkle.Name = "btnOyunucEkle";
            this.btnOyunucEkle.Size = new System.Drawing.Size(84, 30);
            this.btnOyunucEkle.TabIndex = 18;
            this.btnOyunucEkle.Text = "Oyuncu Ekle";
            this.btnOyunucEkle.UseVisualStyleBackColor = false;
            this.btnOyunucEkle.Click += new System.EventHandler(this.btnOyunucEkle_Click);
            // 
            // txtmevkii
            // 
            this.txtmevkii.Location = new System.Drawing.Point(150, 267);
            this.txtmevkii.Name = "txtmevkii";
            this.txtmevkii.Size = new System.Drawing.Size(121, 20);
            this.txtmevkii.TabIndex = 0;
            // 
            // cmbTakimlar
            // 
            this.cmbTakimlar.FormattingEnabled = true;
            this.cmbTakimlar.Location = new System.Drawing.Point(150, 293);
            this.cmbTakimlar.Name = "cmbTakimlar";
            this.cmbTakimlar.Size = new System.Drawing.Size(121, 21);
            this.cmbTakimlar.TabIndex = 19;
            this.cmbTakimlar.SelectedIndexChanged += new System.EventHandler(this.cmbTakimlar_SelectedIndexChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn1.HeaderText = "TAKIM";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 311;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkLabel2.Location = new System.Drawing.Point(44, 297);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(61, 17);
            this.linkLabel2.TabIndex = 30;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Takımı : ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkLabel1.Location = new System.Drawing.Point(44, 240);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 17);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Oyuncu Adı";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkLabel3.Location = new System.Drawing.Point(44, 267);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(85, 17);
            this.linkLabel3.TabIndex = 29;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Mevkii (İNT)";
            // 
            // txtduzMevki
            // 
            this.txtduzMevki.Location = new System.Drawing.Point(399, 271);
            this.txtduzMevki.Name = "txtduzMevki";
            this.txtduzMevki.Size = new System.Drawing.Size(121, 20);
            this.txtduzMevki.TabIndex = 0;
            // 
            // cmbDuzTakım
            // 
            this.cmbDuzTakım.FormattingEnabled = true;
            this.cmbDuzTakım.Location = new System.Drawing.Point(399, 297);
            this.cmbDuzTakım.Name = "cmbDuzTakım";
            this.cmbDuzTakım.Size = new System.Drawing.Size(121, 21);
            this.cmbDuzTakım.TabIndex = 19;
            this.cmbDuzTakım.SelectedIndexChanged += new System.EventHandler(this.cmbTakimlar_SelectedIndexChanged);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkLabel4.Location = new System.Drawing.Point(293, 244);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(80, 17);
            this.linkLabel4.TabIndex = 29;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Oyuncu Adı";
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkLabel5.Location = new System.Drawing.Point(293, 271);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(85, 17);
            this.linkLabel5.TabIndex = 29;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Mevkii (İNT)";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel6.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkLabel6.Location = new System.Drawing.Point(293, 301);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(61, 17);
            this.linkLabel6.TabIndex = 30;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Takımı : ";
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel7.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkLabel7.Location = new System.Drawing.Point(44, 320);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(45, 17);
            this.linkLabel7.TabIndex = 32;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Resim";
            // 
            // txtResim
            // 
            this.txtResim.Location = new System.Drawing.Point(150, 320);
            this.txtResim.Name = "txtResim";
            this.txtResim.Size = new System.Drawing.Size(121, 20);
            this.txtResim.TabIndex = 31;
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel8.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkLabel8.Location = new System.Drawing.Point(293, 326);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(80, 17);
            this.linkLabel8.TabIndex = 34;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Oyuncu Adı";
            // 
            // txtDuzResim
            // 
            this.txtDuzResim.Location = new System.Drawing.Point(399, 326);
            this.txtDuzResim.Name = "txtDuzResim";
            this.txtDuzResim.Size = new System.Drawing.Size(121, 20);
            this.txtDuzResim.TabIndex = 33;
            // 
            // txtdüzOyuncuAd
            // 
            this.txtdüzOyuncuAd.Location = new System.Drawing.Point(399, 244);
            this.txtdüzOyuncuAd.Name = "txtdüzOyuncuAd";
            this.txtdüzOyuncuAd.Size = new System.Drawing.Size(121, 20);
            this.txtdüzOyuncuAd.TabIndex = 0;
            // 
            // btnOyuncuDuzenle
            // 
            this.btnOyuncuDuzenle.BackColor = System.Drawing.Color.Brown;
            this.btnOyuncuDuzenle.FlatAppearance.BorderSize = 0;
            this.btnOyuncuDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOyuncuDuzenle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOyuncuDuzenle.Location = new System.Drawing.Point(436, 354);
            this.btnOyuncuDuzenle.Margin = new System.Windows.Forms.Padding(2);
            this.btnOyuncuDuzenle.Name = "btnOyuncuDuzenle";
            this.btnOyuncuDuzenle.Size = new System.Drawing.Size(84, 36);
            this.btnOyuncuDuzenle.TabIndex = 35;
            this.btnOyuncuDuzenle.Text = "Oyuncu Düzenle";
            this.btnOyuncuDuzenle.UseVisualStyleBackColor = false;
            this.btnOyuncuDuzenle.Click += new System.EventHandler(this.btnOyuncuDuzenle_Click);
            // 
            // dgvOyuncular
            // 
            this.dgvOyuncular.AllowUserToAddRows = false;
            this.dgvOyuncular.AllowUserToDeleteRows = false;
            this.dgvOyuncular.AutoGenerateColumns = false;
            this.dgvOyuncular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOyuncular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerNameDataGridViewTextBoxColumn,
            this.mevkiiDataGridViewTextBoxColumn,
            this.playerTeamNameDataGridViewTextBoxColumn});
            this.dgvOyuncular.DataSource = this.playerBindingSource;
            this.dgvOyuncular.Location = new System.Drawing.Point(31, 12);
            this.dgvOyuncular.Name = "dgvOyuncular";
            this.dgvOyuncular.ReadOnly = true;
            this.dgvOyuncular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOyuncular.Size = new System.Drawing.Size(585, 217);
            this.dgvOyuncular.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(541, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 37;
            this.button1.Text = "OYUNCU SİL ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // playerNameDataGridViewTextBoxColumn
            // 
            this.playerNameDataGridViewTextBoxColumn.DataPropertyName = "PlayerName";
            this.playerNameDataGridViewTextBoxColumn.HeaderText = "OYUNCU ADI ";
            this.playerNameDataGridViewTextBoxColumn.Name = "playerNameDataGridViewTextBoxColumn";
            this.playerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mevkiiDataGridViewTextBoxColumn
            // 
            this.mevkiiDataGridViewTextBoxColumn.DataPropertyName = "Mevkii";
            this.mevkiiDataGridViewTextBoxColumn.HeaderText = "Mevkii";
            this.mevkiiDataGridViewTextBoxColumn.Name = "mevkiiDataGridViewTextBoxColumn";
            this.mevkiiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playerTeamNameDataGridViewTextBoxColumn
            // 
            this.playerTeamNameDataGridViewTextBoxColumn.DataPropertyName = "PlayerTeamName";
            this.playerTeamNameDataGridViewTextBoxColumn.HeaderText = "TAKIM";
            this.playerTeamNameDataGridViewTextBoxColumn.Name = "playerTeamNameDataGridViewTextBoxColumn";
            this.playerTeamNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(İcerisiSampiyonsLigi.Models.Player);
            // 
            // OyuncuEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvOyuncular);
            this.Controls.Add(this.btnOyuncuDuzenle);
            this.Controls.Add(this.linkLabel8);
            this.Controls.Add(this.txtDuzResim);
            this.Controls.Add(this.linkLabel7);
            this.Controls.Add(this.txtResim);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cmbDuzTakım);
            this.Controls.Add(this.cmbTakimlar);
            this.Controls.Add(this.btnOyunucEkle);
            this.Controls.Add(this.lblAnaMenu);
            this.Controls.Add(this.txtduzMevki);
            this.Controls.Add(this.txtmevkii);
            this.Controls.Add(this.txtdüzOyuncuAd);
            this.Controls.Add(this.txtOyuncuAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OyuncuEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OyuncuEkleme";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOyuncular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOyuncuAdi;
        private System.Windows.Forms.LinkLabel lblAnaMenu;
        private System.Windows.Forms.Button btnOyunucEkle;
        private System.Windows.Forms.TextBox txtmevkii;
        private System.Windows.Forms.ComboBox cmbTakimlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.TextBox txtduzMevki;
        private System.Windows.Forms.ComboBox cmbDuzTakım;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.TextBox txtResim;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.TextBox txtDuzResim;
        private System.Windows.Forms.TextBox txtdüzOyuncuAd;
        private System.Windows.Forms.Button btnOyuncuDuzenle;
        private System.Windows.Forms.DataGridView dgvOyuncular;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mevkiiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerTeamNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.Button button1;
    }
}