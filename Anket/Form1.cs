using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Anket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public OleDbCommand cmnd = new OleDbCommand();
        public OleDbConnection cnnct = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb");
        public string ad, soyad, numara;
       
        private void button1_Click(object sender, EventArgs e)
        {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    ad = textBox1.Text;
                    soyad = textBox2.Text;
                    numara = textBox3.Text;
                    cmnd.Connection = cnnct;
                    cmnd.CommandText = "Insert Into ogrenci (ogr_num,ad,soyad) Values ('" + numara + "','" + ad + "','" + soyad + "')";
                    cnnct.Open();
                    cmnd.ExecuteNonQuery();
                    cmnd.Dispose();
                    cnnct.Close();
                    Form2 frm2 = new Form2();
                    
                    frm2.ShowDialog();
                    Form1 frm1 = new Form1();
                    frm1.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Fill in empty fields");
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://plus.google.com/u/0/114708666571898249208");
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
