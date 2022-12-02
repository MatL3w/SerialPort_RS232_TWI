using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace INŻYNIERKA
{
    public partial class ProperitiesForm : Form
    {
        MainForm glowneOkno = null;
        string[] listaportow;
        public ProperitiesForm()
        {
            InitializeComponent();
        }
        public ProperitiesForm(Form frm)
        {
            glowneOkno = frm as MainForm;
            InitializeComponent();
        }

        private void button_ProperitiesOK_Click(object sender, EventArgs e)
        {

            if (comboBox_listaPortowCom.SelectedItem != null)
            {
                if (this.glowneOkno.PORT.IsOpen)
                {
                    this.glowneOkno.PORT.Close();
                }
                this.glowneOkno.PORT.PortName = comboBox_listaPortowCom.SelectedItem.ToString();
                this.glowneOkno.Label_NazwaObslugiwanegoPortu.Text = comboBox_listaPortowCom.SelectedItem.ToString();
                this.glowneOkno.PORT.Open();




                this.glowneOkno.Label_NazwaObslugiwanegoPortu.BackColor = Color.Green;
                this.Hide();
            }
            else
            {
                MessageBox.Show("wybierz PORT");
            }
        }

        private void ProperitiesForm_Load(object sender, EventArgs e)
        {
            Przeszukiwanie_Portow();
        }
        private void Przeszukiwanie_Portow()
        {
          listaportow =  SerialPort.GetPortNames();
            comboBox_listaPortowCom.Items.Clear();
            comboBox_listaPortowCom.Items.AddRange(listaportow);
        }

        private void button_odswiez_Click(object sender, EventArgs e)
        {
            Przeszukiwanie_Portow();
        }
    }
}
