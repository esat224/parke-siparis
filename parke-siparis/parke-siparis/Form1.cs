using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parke_siparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // ComboBox renk seçeneklerini ekleyelim
            comboBox1.Items.Add("Meşe");
            comboBox1.Items.Add("Ceviz");
            comboBox1.Items.Add("Kestane");
            comboBox1.Items.Add("Akasya");

            // Varsayılan seçili değeri ayarla
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(textBox1.Text, out double metrekare))
                {
                    double fiyat = metrekare * 40;
                    textBox2.Text = fiyat.ToString("F2") + " TL";
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir metrekare değeri girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
