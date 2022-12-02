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
    public partial class MainForm : Form
    {
        ProperitiesForm oknoWlasciwosci;
        char[] tablica;
        int[] tablicaAdresow = new int[120];
        char adres = new char();
        int indeksTablicyAdresow = 0;
        bool AdresyTWI = false;

        public MainForm()
        {
            InitializeComponent();

        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            oknoWlasciwosci = new ProperitiesForm(this);

        }

        private void połaczenieToolStripMenuItem_Click(object sender, EventArgs e)
        {

            oknoWlasciwosci.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem.ToString() == "RS 232")
            {
                textBox_TextDoWyslania.Show();
                button_wyslij.Show();
                textBox_Odczyt.Show();
                comboBox_listaAdresowTWI.Hide();
                button_odbierzPoTWI.Hide();
                button_OdswieListaAdresowTWI.Hide();
            }
            if (comboBox1.SelectedItem.ToString() == "TWI")
            {
                textBox_TextDoWyslania.Show();
                button_wyslij.Show();
                textBox_Odczyt.Show();
                comboBox_listaAdresowTWI.Show();
                button_OdswieListaAdresowTWI.Show();
            }
        }

        private void button_wyslij_Click(object sender, EventArgs e)
        {
            if (PORT.IsOpen)
            {
                if (textBox_TextDoWyslania.Text != null)
                {







                    if (comboBox1.SelectedItem.ToString() == "RS 232")
                    {
                        tablica = textBox_TextDoWyslania.Text.ToCharArray();
                        for (int i = 0; i < tablica.Length; i++)
                        {
                            PORT.Write("R" + tablica[i]);

                        }
                    }
                    if (comboBox1.SelectedItem.ToString() == "TWI")
                    {
                        tablica = textBox_TextDoWyslania.Text.ToCharArray();
                        int x = Int32.Parse(comboBox_listaAdresowTWI.SelectedItem.ToString());
                        for (int i = 0; i < tablica.Length; i++)
                        {
                            PORT.Write("A" + (char)x + "T" + tablica[i]);



                        }
                    }

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (AdresyTWI)
            {
                if (PORT.IsOpen && PORT.BytesToRead > 0)
                {
                    adres = (char)PORT.ReadChar();
                    if (adres == 'c')
                    {
                        for (int i = 0; i < tablicaAdresow.Length; i++)
                        {
                            if (tablicaAdresow[i] == 0)
                            {

                            }
                            else
                            {
                                comboBox_listaAdresowTWI.Items.Add(tablicaAdresow[i].ToString());
                            }

                        }
                        AdresyTWI = false;
                    }
                    else
                    {
                        tablicaAdresow[indeksTablicyAdresow] = (int)adres;
                        indeksTablicyAdresow++;
                    }

                }
            }
            else
            {
                if (PORT.IsOpen && PORT.BytesToRead > 0)
                {
                    textBox_Odczyt.Text += PORT.ReadChar();
                }
            }



        }

        private void button_OdswieListaAdresowTWI_Click(object sender, EventArgs e)
        {
            comboBox_listaAdresowTWI.Items.Clear();
            for (int i = 0; i < tablicaAdresow.Length; i++)
            {
                tablicaAdresow[i] = 0;
            }
            indeksTablicyAdresow = 0;
            PORT.Write("XT");
            AdresyTWI = true;

        }

        private void button_czyszczenieOknaOdbiorczegoi_Click(object sender, EventArgs e)
        {
            textBox_Odczyt.Clear();
        }

        private void button_odbierzPoTWI_Click(object sender, EventArgs e)
        {

            if (PORT.IsOpen)
            {



                if (comboBox1.SelectedItem.ToString() == "TWI" && comboBox_listaAdresowTWI.SelectedItem != null)
                {

                    int x = Int32.Parse(comboBox_listaAdresowTWI.SelectedItem.ToString());

                    PORT.Write("S" + (char)x + "D" + (char)x);






                }

            }
        }

        private void button_wyslaj_tablice_TWI_Click(object sender, EventArgs e)
        {
            if (PORT.IsOpen)
            {
                if (textBox_TextDoWyslania.Text != null)
                {
                    tablica = textBox_TextDoWyslania.Text.ToCharArray();
                    int x = Int32.Parse(comboBox_listaAdresowTWI.SelectedItem.ToString());
                    PORT.Write("W" + (char)x);
                    for(int i =0;i<tablica.Length;i++)
                    {
                        PORT.Write("$" + tablica[i]);
                    }
                    PORT.Write("cc");
                }
            }
        }
    }
}

