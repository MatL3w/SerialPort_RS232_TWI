namespace INŻYNIERKA
{
    partial class MainForm
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
            this.Label_NazwaObslugiwanegoPortu = new System.Windows.Forms.Label();
            this.PORT = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.portSzeregowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.połaczenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_TextDoWyslania = new System.Windows.Forms.TextBox();
            this.button_wyslij = new System.Windows.Forms.Button();
            this.textBox_Odczyt = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_listaAdresowTWI = new System.Windows.Forms.ComboBox();
            this.button_OdswieListaAdresowTWI = new System.Windows.Forms.Button();
            this.button_czyszczenieOknaOdbiorczegoi = new System.Windows.Forms.Button();
            this.button_odbierzPoTWI = new System.Windows.Forms.Button();
            this.button_wyslaj_tablice_TWI = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_NazwaObslugiwanegoPortu
            // 
            this.Label_NazwaObslugiwanegoPortu.Location = new System.Drawing.Point(12, 42);
            this.Label_NazwaObslugiwanegoPortu.Name = "Label_NazwaObslugiwanegoPortu";
            this.Label_NazwaObslugiwanegoPortu.Size = new System.Drawing.Size(185, 21);
            this.Label_NazwaObslugiwanegoPortu.TabIndex = 0;
            this.Label_NazwaObslugiwanegoPortu.Text = "Nazwa Portu:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portSzeregowyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(529, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // portSzeregowyToolStripMenuItem
            // 
            this.portSzeregowyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.połaczenieToolStripMenuItem});
            this.portSzeregowyToolStripMenuItem.Name = "portSzeregowyToolStripMenuItem";
            this.portSzeregowyToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.portSzeregowyToolStripMenuItem.Text = "Port szeregowy";
            // 
            // połaczenieToolStripMenuItem
            // 
            this.połaczenieToolStripMenuItem.Name = "połaczenieToolStripMenuItem";
            this.połaczenieToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.połaczenieToolStripMenuItem.Text = "Połaczenie";
            this.połaczenieToolStripMenuItem.Click += new System.EventHandler(this.połaczenieToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "TWI",
            "RS 232"});
            this.comboBox1.Location = new System.Drawing.Point(284, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox_TextDoWyslania
            // 
            this.textBox_TextDoWyslania.Location = new System.Drawing.Point(15, 137);
            this.textBox_TextDoWyslania.Multiline = true;
            this.textBox_TextDoWyslania.Name = "textBox_TextDoWyslania";
            this.textBox_TextDoWyslania.Size = new System.Drawing.Size(202, 153);
            this.textBox_TextDoWyslania.TabIndex = 3;
            this.textBox_TextDoWyslania.Visible = false;
            // 
            // button_wyslij
            // 
            this.button_wyslij.Location = new System.Drawing.Point(250, 228);
            this.button_wyslij.Name = "button_wyslij";
            this.button_wyslij.Size = new System.Drawing.Size(110, 61);
            this.button_wyslij.TabIndex = 4;
            this.button_wyslij.Text = "Wyslij";
            this.button_wyslij.UseVisualStyleBackColor = true;
            this.button_wyslij.Visible = false;
            this.button_wyslij.Click += new System.EventHandler(this.button_wyslij_Click);
            // 
            // textBox_Odczyt
            // 
            this.textBox_Odczyt.Enabled = false;
            this.textBox_Odczyt.Location = new System.Drawing.Point(15, 296);
            this.textBox_Odczyt.Multiline = true;
            this.textBox_Odczyt.Name = "textBox_Odczyt";
            this.textBox_Odczyt.Size = new System.Drawing.Size(202, 96);
            this.textBox_Odczyt.TabIndex = 5;
            this.textBox_Odczyt.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // comboBox_listaAdresowTWI
            // 
            this.comboBox_listaAdresowTWI.FormattingEnabled = true;
            this.comboBox_listaAdresowTWI.Location = new System.Drawing.Point(284, 137);
            this.comboBox_listaAdresowTWI.Name = "comboBox_listaAdresowTWI";
            this.comboBox_listaAdresowTWI.Size = new System.Drawing.Size(121, 24);
            this.comboBox_listaAdresowTWI.TabIndex = 7;
            this.comboBox_listaAdresowTWI.Visible = false;
            // 
            // button_OdswieListaAdresowTWI
            // 
            this.button_OdswieListaAdresowTWI.Location = new System.Drawing.Point(433, 137);
            this.button_OdswieListaAdresowTWI.Name = "button_OdswieListaAdresowTWI";
            this.button_OdswieListaAdresowTWI.Size = new System.Drawing.Size(79, 23);
            this.button_OdswieListaAdresowTWI.TabIndex = 8;
            this.button_OdswieListaAdresowTWI.Text = "odswiez";
            this.button_OdswieListaAdresowTWI.UseVisualStyleBackColor = true;
            this.button_OdswieListaAdresowTWI.Visible = false;
            this.button_OdswieListaAdresowTWI.Click += new System.EventHandler(this.button_OdswieListaAdresowTWI_Click);
            // 
            // button_czyszczenieOknaOdbiorczegoi
            // 
            this.button_czyszczenieOknaOdbiorczegoi.Location = new System.Drawing.Point(253, 323);
            this.button_czyszczenieOknaOdbiorczegoi.Name = "button_czyszczenieOknaOdbiorczegoi";
            this.button_czyszczenieOknaOdbiorczegoi.Size = new System.Drawing.Size(106, 56);
            this.button_czyszczenieOknaOdbiorczegoi.TabIndex = 9;
            this.button_czyszczenieOknaOdbiorczegoi.Text = "czysc";
            this.button_czyszczenieOknaOdbiorczegoi.UseVisualStyleBackColor = true;
            this.button_czyszczenieOknaOdbiorczegoi.Click += new System.EventHandler(this.button_czyszczenieOknaOdbiorczegoi_Click);
            // 
            // button_odbierzPoTWI
            // 
            this.button_odbierzPoTWI.Location = new System.Drawing.Point(401, 229);
            this.button_odbierzPoTWI.Name = "button_odbierzPoTWI";
            this.button_odbierzPoTWI.Size = new System.Drawing.Size(97, 60);
            this.button_odbierzPoTWI.TabIndex = 10;
            this.button_odbierzPoTWI.Text = "Odbierz";
            this.button_odbierzPoTWI.UseVisualStyleBackColor = true;
            this.button_odbierzPoTWI.Click += new System.EventHandler(this.button_odbierzPoTWI_Click);
            // 
            // button_wyslaj_tablice_TWI
            // 
            this.button_wyslaj_tablice_TWI.Location = new System.Drawing.Point(260, 179);
            this.button_wyslaj_tablice_TWI.Name = "button_wyslaj_tablice_TWI";
            this.button_wyslaj_tablice_TWI.Size = new System.Drawing.Size(98, 38);
            this.button_wyslaj_tablice_TWI.TabIndex = 11;
            this.button_wyslaj_tablice_TWI.Text = "tablica TWI";
            this.button_wyslaj_tablice_TWI.UseVisualStyleBackColor = true;
            this.button_wyslaj_tablice_TWI.Click += new System.EventHandler(this.button_wyslaj_tablice_TWI_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 408);
            this.Controls.Add(this.button_wyslaj_tablice_TWI);
            this.Controls.Add(this.button_odbierzPoTWI);
            this.Controls.Add(this.button_czyszczenieOknaOdbiorczegoi);
            this.Controls.Add(this.button_OdswieListaAdresowTWI);
            this.Controls.Add(this.comboBox_listaAdresowTWI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Odczyt);
            this.Controls.Add(this.button_wyslij);
            this.Controls.Add(this.textBox_TextDoWyslania);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Label_NazwaObslugiwanegoPortu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Program";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Label_NazwaObslugiwanegoPortu;
        public System.IO.Ports.SerialPort PORT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem portSzeregowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem połaczenieToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_TextDoWyslania;
        private System.Windows.Forms.Button button_wyslij;
        public System.Windows.Forms.TextBox textBox_Odczyt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_listaAdresowTWI;
        private System.Windows.Forms.Button button_OdswieListaAdresowTWI;
        private System.Windows.Forms.Button button_czyszczenieOknaOdbiorczegoi;
        private System.Windows.Forms.Button button_odbierzPoTWI;
        private System.Windows.Forms.Button button_wyslaj_tablice_TWI;
    }
}

