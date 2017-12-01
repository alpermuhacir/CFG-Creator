using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WriteCFG_for_csGO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.FileName = "*";
                saveFileDialog1.Filter = "Configure Files (*cfg)|*.cfg";
                saveFileDialog1.DefaultExt = "cfg";
                saveFileDialog1.ShowDialog();

                StreamWriter yazmaIslemi = new StreamWriter(saveFileDialog1.FileName);
                yazmaIslemi.WriteLine(txtCfgYaz.Text);
                yazmaIslemi.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                StreamReader okumaIslemi = new StreamReader(ofd.FileName);
                txtOku.Text = okumaIslemi.ReadToEnd();
                okumaIslemi.Close();
                /*openFileDialog2.FileName = "Okumak İstediğiniz CFG Dosyasını Seçiniz.";
                openFileDialog2.Filter = "Configure Files (*cfg)|*.cfg";
                openFileDialog2.OpenFile();

                StreamReader okumaIslemi = new StreamReader(openFileDialog2.FileName);
                txtOku.Text = okumaIslemi.ReadToEnd();
                okumaIslemi.Close();*/
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
        }
    }
}
