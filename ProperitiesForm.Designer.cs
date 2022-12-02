namespace INŻYNIERKA
{
    partial class ProperitiesForm
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
            this.button_ProperitiesOK = new System.Windows.Forms.Button();
            this.comboBox_listaPortowCom = new System.Windows.Forms.ComboBox();
            this.label_listaPortowCOM = new System.Windows.Forms.Label();
            this.button_odswiez = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_ProperitiesOK
            // 
            this.button_ProperitiesOK.Location = new System.Drawing.Point(41, 110);
            this.button_ProperitiesOK.Name = "button_ProperitiesOK";
            this.button_ProperitiesOK.Size = new System.Drawing.Size(140, 67);
            this.button_ProperitiesOK.TabIndex = 0;
            this.button_ProperitiesOK.Text = "OK";
            this.button_ProperitiesOK.UseVisualStyleBackColor = true;
            this.button_ProperitiesOK.Click += new System.EventHandler(this.button_ProperitiesOK_Click);
            // 
            // comboBox_listaPortowCom
            // 
            this.comboBox_listaPortowCom.FormattingEnabled = true;
            this.comboBox_listaPortowCom.Location = new System.Drawing.Point(41, 51);
            this.comboBox_listaPortowCom.Name = "comboBox_listaPortowCom";
            this.comboBox_listaPortowCom.Size = new System.Drawing.Size(121, 24);
            this.comboBox_listaPortowCom.TabIndex = 1;
            // 
            // label_listaPortowCOM
            // 
            this.label_listaPortowCOM.AutoSize = true;
            this.label_listaPortowCOM.Location = new System.Drawing.Point(38, 20);
            this.label_listaPortowCOM.Name = "label_listaPortowCOM";
            this.label_listaPortowCOM.Size = new System.Drawing.Size(107, 17);
            this.label_listaPortowCOM.TabIndex = 2;
            this.label_listaPortowCOM.Text = "listaPortowCOM";
            // 
            // button_odswiez
            // 
            this.button_odswiez.Location = new System.Drawing.Point(177, 51);
            this.button_odswiez.Name = "button_odswiez";
            this.button_odswiez.Size = new System.Drawing.Size(107, 24);
            this.button_odswiez.TabIndex = 3;
            this.button_odswiez.Text = "odśwież";
            this.button_odswiez.UseVisualStyleBackColor = true;
            this.button_odswiez.Click += new System.EventHandler(this.button_odswiez_Click);
            // 
            // ProperitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 217);
            this.ControlBox = false;
            this.Controls.Add(this.button_odswiez);
            this.Controls.Add(this.label_listaPortowCOM);
            this.Controls.Add(this.comboBox_listaPortowCom);
            this.Controls.Add(this.button_ProperitiesOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProperitiesForm";
            this.Text = "ProperitiesForm";
            this.Load += new System.EventHandler(this.ProperitiesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ProperitiesOK;
        private System.Windows.Forms.ComboBox comboBox_listaPortowCom;
        private System.Windows.Forms.Label label_listaPortowCOM;
        private System.Windows.Forms.Button button_odswiez;
    }
}