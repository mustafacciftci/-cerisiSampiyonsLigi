
namespace İcerisiSampiyonsLigi
{
    partial class Renkler
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
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.nudg = new System.Windows.Forms.NumericUpDown();
            this.nudR = new System.Windows.Forms.NumericUpDown();
            this.txtRenkAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstRenkler = new System.Windows.Forms.ListBox();
            this.lblAnaMenu = new System.Windows.Forms.LinkLabel();
            this.btnSil = new System.Windows.Forms.Button();
            this.pboRenk = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRenk)).BeginInit();
            this.SuspendLayout();
            // 
            // nudB
            // 
            this.nudB.Location = new System.Drawing.Point(259, 226);
            this.nudB.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(120, 20);
            this.nudB.TabIndex = 6;
            this.nudB.ValueChanged += new System.EventHandler(this.nudB_ValueChanged);
            // 
            // nudg
            // 
            this.nudg.Location = new System.Drawing.Point(259, 200);
            this.nudg.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudg.Name = "nudg";
            this.nudg.Size = new System.Drawing.Size(120, 20);
            this.nudg.TabIndex = 7;
            this.nudg.ValueChanged += new System.EventHandler(this.nudg_ValueChanged);
            // 
            // nudR
            // 
            this.nudR.Location = new System.Drawing.Point(259, 174);
            this.nudR.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudR.Name = "nudR";
            this.nudR.Size = new System.Drawing.Size(120, 20);
            this.nudR.TabIndex = 8;
            this.nudR.ValueChanged += new System.EventHandler(this.nudR_ValueChanged);
            // 
            // txtRenkAdi
            // 
            this.txtRenkAdi.Location = new System.Drawing.Point(259, 139);
            this.txtRenkAdi.Name = "txtRenkAdi";
            this.txtRenkAdi.Size = new System.Drawing.Size(120, 20);
            this.txtRenkAdi.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(289, 252);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(90, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "RENGİ EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstRenkler
            // 
            this.lstRenkler.FormattingEnabled = true;
            this.lstRenkler.Location = new System.Drawing.Point(12, 25);
            this.lstRenkler.Name = "lstRenkler";
            this.lstRenkler.Size = new System.Drawing.Size(181, 264);
            this.lstRenkler.TabIndex = 10;
            this.lstRenkler.SelectedIndexChanged += new System.EventHandler(this.lstRenkler_SelectedIndexChanged);
            // 
            // lblAnaMenu
            // 
            this.lblAnaMenu.AutoSize = true;
            this.lblAnaMenu.Location = new System.Drawing.Point(9, 319);
            this.lblAnaMenu.Name = "lblAnaMenu";
            this.lblAnaMenu.Size = new System.Drawing.Size(93, 13);
            this.lblAnaMenu.TabIndex = 11;
            this.lblAnaMenu.TabStop = true;
            this.lblAnaMenu.Text = "Ana Menüye Dön ";
            this.lblAnaMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAnaMenu_LinkClicked);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(118, 295);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pboRenk
            // 
            this.pboRenk.Location = new System.Drawing.Point(238, 25);
            this.pboRenk.Name = "pboRenk";
            this.pboRenk.Size = new System.Drawing.Size(141, 102);
            this.pboRenk.TabIndex = 9;
            this.pboRenk.TabStop = false;
            // 
            // Renkler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(435, 341);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblAnaMenu);
            this.Controls.Add(this.lstRenkler);
            this.Controls.Add(this.pboRenk);
            this.Controls.Add(this.nudB);
            this.Controls.Add(this.nudg);
            this.Controls.Add(this.nudR);
            this.Controls.Add(this.txtRenkAdi);
            this.Controls.Add(this.btnEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Renkler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renkler";
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRenk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboRenk;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.NumericUpDown nudg;
        private System.Windows.Forms.NumericUpDown nudR;
        private System.Windows.Forms.TextBox txtRenkAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstRenkler;
        private System.Windows.Forms.LinkLabel lblAnaMenu;
        private System.Windows.Forms.Button btnSil;
    }
}