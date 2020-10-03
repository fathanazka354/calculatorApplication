using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consoleWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Penambahan(int a, int b)
        {
            return a + b;
        }
        private int Pengurangan(int a, int b)
        {
            return a - b;
        }

        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_operasi(object sender, EventArgs e)
        {
            /*bPilihan.Items.Add("Pertambahan");
            bPilihan.Items.Add("Pengurangan");
            bPilihan.Items.Add("Perkalian");
            bPilihan.Items.Add("Pembagian");*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string operasi1 = bPilihan.SelectedIndex.ToString();
            object pilihan = bPilihan.SelectedItem;
            string operasi2 = pilihan.ToString();
            var a = int.Parse(txtBil1.Text);
            var b = Convert.ToInt32(txtBil2.Text);

            txtHasil.Items.Clear();

            if(operasi2 == "Pertambahan"){
                txtHasil.Items.Add(string.Format("Hasil Penjumlahan dari : {0} + {1} = {2}", a, b, Penambahan(a, b)));
            }
            else if(operasi2 == "Pengurangan")
            {
                txtHasil.Items.Add(string.Format("Hasil Pengurangan dari : {0} - {1} = {2}", a, b, Pengurangan(a, b)));
            }
            else if(operasi2 == "Perkalian")
            {
                txtHasil.Items.Add(string.Format("Hasil Perkalian dari : {0} x {1} = {2}", a, b, Perkalian(a, b)));
            }
            else if(operasi2 == "Pembagian")
            {
                txtHasil.Items.Add(string.Format("Hasil Pembagian dari : {0} / {1} = {2}", a, b, Pembagian(a, b)));
            }
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
