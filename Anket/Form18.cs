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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true || radioButton6.Checked == true || radioButton5.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    Form1 frm1 = new Form1();
                    frm1.cmnd.Connection = frm1.cnnct;
                    frm1.cmnd.CommandText = "Update ogrenci Set s16= '" + radioButton1.Text + "';";
                    frm1.cnnct.Open();
                    frm1.cmnd.ExecuteNonQuery();
                    frm1.cmnd.Dispose();
                    frm1.cnnct.Close();
                    Form19 frm19 = new Form19();
                    this.Hide();
                    frm19.ShowDialog();
                }
                else if (radioButton2.Checked == true)
                {
                    Form1 frm1 = new Form1();
                    frm1.cmnd.Connection = frm1.cnnct;
                    frm1.cmnd.CommandText = "Update ogrenci Set s16= '" + radioButton2.Text + "';";
                    frm1.cnnct.Open();
                    frm1.cmnd.ExecuteNonQuery();
                    frm1.cmnd.Dispose();
                    frm1.cnnct.Close();
                    Form19 frm19 = new Form19();
                    this.Hide();
                    frm19.ShowDialog();
                }
                else if (radioButton3.Checked == true)
                {
                    Form1 frm1 = new Form1();
                    frm1.cmnd.Connection = frm1.cnnct;
                    frm1.cmnd.CommandText = "Update ogrenci Set s16= '" + radioButton3.Text + "';";
                    frm1.cnnct.Open();
                    frm1.cmnd.ExecuteNonQuery();
                    frm1.cmnd.Dispose();
                    frm1.cnnct.Close();
                    Form19 frm19 = new Form19();
                    this.Hide();
                    frm19.ShowDialog();
                }
                else if (radioButton4.Checked == true)
                {
                    Form1 frm1 = new Form1();
                    frm1.cmnd.Connection = frm1.cnnct;
                    frm1.cmnd.CommandText = "Update ogrenci Set s16= '" + radioButton4.Text + "';";
                    frm1.cnnct.Open();
                    frm1.cmnd.ExecuteNonQuery();
                    frm1.cmnd.Dispose();
                    frm1.cnnct.Close();
                    Form19 frm19 = new Form19();
                    this.Hide();
                    frm19.ShowDialog();
                }
                else if (radioButton5.Checked == true)
                {
                    Form1 frm1 = new Form1();
                    frm1.cmnd.Connection = frm1.cnnct;
                    frm1.cmnd.CommandText = "Update ogrenci Set s16= '" + radioButton5.Text + "';";
                    frm1.cnnct.Open();
                    frm1.cmnd.ExecuteNonQuery();
                    frm1.cmnd.Dispose();
                    frm1.cnnct.Close();
                    Form19 frm19 = new Form19();
                    this.Hide();
                    frm19.ShowDialog();
                }
                else if (radioButton6.Checked == true)
                {
                    Form1 frm1 = new Form1();
                    frm1.cmnd.Connection = frm1.cnnct;
                    frm1.cmnd.CommandText = "Update ogrenci Set s16= '" + radioButton6.Text + "';";
                    frm1.cnnct.Open();
                    frm1.cmnd.ExecuteNonQuery();
                    frm1.cmnd.Dispose();
                    frm1.cnnct.Close();
                    Form19 frm19 = new Form19();
                    this.Hide();
                    frm19.ShowDialog();
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
            Form17 frm17 = new Form17();
            this.Hide();
            frm17.ShowDialog();
        }
    }
}
