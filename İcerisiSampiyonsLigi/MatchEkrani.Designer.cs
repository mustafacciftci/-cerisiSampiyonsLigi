
namespace İcerisiSampiyonsLigi
{
    partial class MatchEkrani
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAnaMenu = new System.Windows.Forms.LinkLabel();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbTeam2inMatch = new System.Windows.Forms.ComboBox();
            this.cmbTeam1inMatch = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.nudEv = new System.Windows.Forms.NumericUpDown();
            this.nudDeplasman = new System.Windows.Forms.NumericUpDown();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pboEv = new System.Windows.Forms.PictureBox();
            this.pboDeplasman = new System.Windows.Forms.PictureBox();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.matchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matchTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team1TeamNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team2TeamNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudEv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeplasman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboEv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboDeplasman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnaMenu
            // 
            this.lblAnaMenu.AutoSize = true;
            this.lblAnaMenu.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnaMenu.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.lblAnaMenu.Location = new System.Drawing.Point(12, 424);
            this.lblAnaMenu.Name = "lblAnaMenu";
            this.lblAnaMenu.Size = new System.Drawing.Size(119, 17);
            this.lblAnaMenu.TabIndex = 17;
            this.lblAnaMenu.TabStop = true;
            this.lblAnaMenu.Text = "Ana Menüye Dön ";
            this.lblAnaMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAnaMenu_LinkClicked);
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm ";
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(378, 86);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(153, 26);
            this.dtpTime.TabIndex = 26;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(375, 38);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(2021, 10, 19, 14, 35, 19, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(156, 26);
            this.dtpDate.TabIndex = 25;
            this.dtpDate.Value = new System.DateTime(2021, 10, 19, 14, 35, 19, 0);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // cmbTeam2inMatch
            // 
            this.cmbTeam2inMatch.DisplayMember = "TeamName";
            this.cmbTeam2inMatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeam2inMatch.FormattingEnabled = true;
            this.cmbTeam2inMatch.Location = new System.Drawing.Point(112, 87);
            this.cmbTeam2inMatch.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTeam2inMatch.Name = "cmbTeam2inMatch";
            this.cmbTeam2inMatch.Size = new System.Drawing.Size(153, 21);
            this.cmbTeam2inMatch.TabIndex = 21;
            this.cmbTeam2inMatch.ValueMember = "Id";
            this.cmbTeam2inMatch.SelectedIndexChanged += new System.EventHandler(this.cmbTeam2inMatch_SelectedIndexChanged);
            // 
            // cmbTeam1inMatch
            // 
            this.cmbTeam1inMatch.DisplayMember = "TeamName";
            this.cmbTeam1inMatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeam1inMatch.FormattingEnabled = true;
            this.cmbTeam1inMatch.Location = new System.Drawing.Point(112, 37);
            this.cmbTeam1inMatch.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTeam1inMatch.Name = "cmbTeam1inMatch";
            this.cmbTeam1inMatch.Size = new System.Drawing.Size(153, 21);
            this.cmbTeam1inMatch.TabIndex = 18;
            this.cmbTeam1inMatch.ValueMember = "Id";
            this.cmbTeam1inMatch.SelectedIndexChanged += new System.EventHandler(this.cmbTeam1inMatch_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkLabel1.Location = new System.Drawing.Point(2, 41);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 17);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "EV SAHİBİ : ";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkLabel2.Location = new System.Drawing.Point(2, 91);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(99, 17);
            this.linkLabel2.TabIndex = 28;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "DEPLASMAN : ";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkLabel3.Location = new System.Drawing.Point(547, 45);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(64, 17);
            this.linkLabel3.TabIndex = 27;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Ev Sahibi";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkLabel4.Location = new System.Drawing.Point(306, 92);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(40, 17);
            this.linkLabel4.TabIndex = 28;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "SAAT";
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDashBoard.Location = new System.Drawing.Point(550, 77);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(192, 37);
            this.btnDashBoard.TabIndex = 29;
            this.btnDashBoard.Text = "Mac Yap";
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // nudEv
            // 
            this.nudEv.Location = new System.Drawing.Point(617, 45);
            this.nudEv.Name = "nudEv";
            this.nudEv.Size = new System.Drawing.Size(41, 20);
            this.nudEv.TabIndex = 31;
            // 
            // nudDeplasman
            // 
            this.nudDeplasman.Location = new System.Drawing.Point(664, 46);
            this.nudDeplasman.Name = "nudDeplasman";
            this.nudDeplasman.Size = new System.Drawing.Size(41, 20);
            this.nudDeplasman.TabIndex = 31;
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkLabel5.Location = new System.Drawing.Point(711, 47);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(77, 17);
            this.linkLabel5.TabIndex = 27;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Deplasman";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel6.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkLabel6.Location = new System.Drawing.Point(306, 42);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(46, 17);
            this.linkLabel6.TabIndex = 27;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "TARİH";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(213, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(355, 217);
            this.dataGridView1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::İcerisiSampiyonsLigi.Properties.Resources.football;
            this.pictureBox1.Location = new System.Drawing.Point(714, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // pboEv
            // 
            this.pboEv.Location = new System.Drawing.Point(15, 159);
            this.pboEv.Name = "pboEv";
            this.pboEv.Size = new System.Drawing.Size(161, 217);
            this.pboEv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboEv.TabIndex = 33;
            this.pboEv.TabStop = false;
            // 
            // pboDeplasman
            // 
            this.pboDeplasman.Location = new System.Drawing.Point(617, 159);
            this.pboDeplasman.Name = "pboDeplasman";
            this.pboDeplasman.Size = new System.Drawing.Size(171, 217);
            this.pboDeplasman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboDeplasman.TabIndex = 33;
            this.pboDeplasman.TabStop = false;
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            this.bunifuDataGridView1.AllowUserToAddRows = false;
            this.bunifuDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView1.AutoGenerateColumns = false;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView1.ColumnHeadersHeight = 40;
            this.bunifuDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matchTimeDataGridViewTextBoxColumn,
            this.team1TeamNameDataGridViewTextBoxColumn,
            this.team2TeamNameDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn,
            this.matchScoreDataGridViewTextBoxColumn});
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuDataGridView1.DataSource = this.matchBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(182, 159);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.ReadOnly = true;
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(429, 217);
            this.bunifuDataGridView1.TabIndex = 34;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // matchBindingSource
            // 
            this.matchBindingSource.DataSource = typeof(İcerisiSampiyonsLigi.Models.Match);
            // 
            // matchTimeDataGridViewTextBoxColumn
            // 
            this.matchTimeDataGridViewTextBoxColumn.DataPropertyName = "MatchTime";
            this.matchTimeDataGridViewTextBoxColumn.HeaderText = "Maç Günü";
            this.matchTimeDataGridViewTextBoxColumn.Name = "matchTimeDataGridViewTextBoxColumn";
            this.matchTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // team1TeamNameDataGridViewTextBoxColumn
            // 
            this.team1TeamNameDataGridViewTextBoxColumn.DataPropertyName = "Team1TeamName";
            this.team1TeamNameDataGridViewTextBoxColumn.HeaderText = "Ev Sahibi";
            this.team1TeamNameDataGridViewTextBoxColumn.Name = "team1TeamNameDataGridViewTextBoxColumn";
            this.team1TeamNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // team2TeamNameDataGridViewTextBoxColumn
            // 
            this.team2TeamNameDataGridViewTextBoxColumn.DataPropertyName = "Team2TeamName";
            this.team2TeamNameDataGridViewTextBoxColumn.HeaderText = "Deplasman";
            this.team2TeamNameDataGridViewTextBoxColumn.Name = "team2TeamNameDataGridViewTextBoxColumn";
            this.team2TeamNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Sonuç";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matchScoreDataGridViewTextBoxColumn
            // 
            this.matchScoreDataGridViewTextBoxColumn.DataPropertyName = "MatchScore";
            this.matchScoreDataGridViewTextBoxColumn.HeaderText = "Maç Skoru";
            this.matchScoreDataGridViewTextBoxColumn.Name = "matchScoreDataGridViewTextBoxColumn";
            this.matchScoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MatchEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuDataGridView1);
            this.Controls.Add(this.pboDeplasman);
            this.Controls.Add(this.pboEv);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nudDeplasman);
            this.Controls.Add(this.nudEv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDashBoard);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbTeam2inMatch);
            this.Controls.Add(this.cmbTeam1inMatch);
            this.Controls.Add(this.lblAnaMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MatchEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MatchEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.nudEv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeplasman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboEv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboDeplasman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblAnaMenu;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbTeam2inMatch;
        private System.Windows.Forms.ComboBox cmbTeam1inMatch;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudEv;
        private System.Windows.Forms.NumericUpDown nudDeplasman;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pboEv;
        private System.Windows.Forms.PictureBox pboDeplasman;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private System.Windows.Forms.BindingSource matchBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn team1TeamNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn team2TeamNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchScoreDataGridViewTextBoxColumn;
    }
}