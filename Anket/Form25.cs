using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anket
{
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    Form1 frm1 = new Form1();
                    frm1.cmnd.Connection = frm1.cnnct;
                    frm1.cmnd.CommandText = "Update ogrenci Set s23= '" + radioButton1.Text + "';";
                    frm1.cnnct.Open();
                    frm1.cmnd.ExecuteNonQuery();
                    frm1.cmnd.Dispose();
                    frm1.cnnct.Close();
                    Form12 frm12 = new Form12();
                    this.Hide();
                    frm12.ShowDialog();
                }
                else if (radioButton2.Checked == true)
                {
                    Form1 frm1 = new Form1();
                    frm1.cmnd.Connection = frm1.cnnct;
                    frm1.cmnd.CommandText = "Update ogrenci Set s23= '" + radioButton2.Text + "';";
                    frm1.cnnct.Open();
                    frm1.cmnd.ExecuteNonQuery();
                    frm1.cmnd.Dispose();
                    frm1.cnnct.Close();
                    Form12 frm12 = new Form12();
                    this.Hide();
                    frm12.ShowDialog();
                }
                else if (radioButton3.Checked == true)
                {
                    Form1 frm1 = new Form1();
                    frm1.cmnd.Connection = frm1.cnnct;
                    frm1.cmnd.CommandText = "Update ogrenci Set s23= '" + radioButton3.Text + "';";
                    frm1.cnnct.Open();
                    frm1.cmnd.ExecuteNonQuery();
                    frm1.cmnd.Dispose();
                    frm1.cnnct.Close();
                    Form12 frm12 = new Form12();
                    this.Hide();
                    frm12.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Choose Please");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form24 frm24 = new Form24();
            this.Hide();
            frm24.ShowDialog();
        }
    }
}
