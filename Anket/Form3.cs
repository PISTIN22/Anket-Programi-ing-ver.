﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true || radioButton6.Checked == true || radioButton5.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    Form1 frm1 = new Form1();
                    frm1.cmnd.Connection = frm1.cnnct;
                    frm1.cmnd.CommandText = "Update ogrenci Set s2= '" + radioButton1.Text + "';";
                    frm1.cnnct.Open();
                    frm1.cmnd.ExecuteNonQuery();
                    frm1.cmnd.Dispose();
                    frm1.cnnct.Close();
                    Form4 frm4 = new Form4();
                    this.Hide();
                    frm4.ShowDialog();
                }
                else if (radioButton2.Checked == true)
                {
                    Form1 frm1 = new Form1();
                    frm1.cmnd.Connection = frm1.cnnct;
                    frm1.cmnd.CommandText = "Update ogrenci Set s2= '" + radioButton2.Text + "';";
                    frm1.cnnct.Open();
                    frm1.cmnd.ExecuteNonQuery();
                    frm1.cmnd.Dispose();
                    frm1.cnnct.Close();
                    Form4 frm4 = new Form4();
                    this.Hide();
                    frm4.ShowDialog();
                }
                else if (radioButton3.Checked == true)
                {
                    Form1 frm1 = new Form1();
                    frm1.cmnd.Connection = frm1.cnnct;
                    frm1.cmnd.CommandText = "Update ogrenci Set s2= '" + radioButton3.Text + "';";
                    frm1.cnnct.Open();
                    frm1.cmnd.ExecuteNonQuery();
                    frm1.cmnd.Dispose();
                    frm1.cnnct.Close();
                    Form4 frm4 = new Form4();
                    this.Hide();
                    frm4.ShowDialog();
                }
                else if (radioButton4.Checked == true)
                {
                    Form1 frm1 = new Form1();
                    frm1.cmnd.Connection = frm1.cnnct;
                    frm1.cmnd.CommandText = "Update ogrenci Set s2= '" + radioButton4.Text + "';";
                    frm1.cnnct.Open();
                    frm1.cmnd.ExecuteNonQuery();
                    frm1.cmnd.Dispose();
                    frm1.cnnct.Close();
                    Form4 frm4 = new Form4();
                    this.Hide();
                    frm4.ShowDialog();
                }
                else if (radioButton5.Checked == true)
                {
                    Form1 frm1 = new Form1();
                    frm1.cmnd.Connection = frm1.cnnct;
                    frm1.cmnd.CommandText = "Update ogrenci Set s2= '" + radioButton5.Text + "';";
                    frm1.cnnct.Open();
                    frm1.cmnd.ExecuteNonQuery();
                    frm1.cmnd.Dispose();
                    frm1.cnnct.Close();
                    Form4 frm4 = new Form4();
                    this.Hide();
                    frm4.ShowDialog();
                }
                else if (radioButton6.Checked == true)
                {
                    Form1 frm1 = new Form1();
                    frm1.cmnd.Connection = frm1.cnnct;
                    frm1.cmnd.CommandText = "Update ogrenci Set s2= '" + radioButton6.Text + "';";
                    frm1.cnnct.Open();
                    frm1.cmnd.ExecuteNonQuery();
                    frm1.cmnd.Dispose();
                    frm1.cnnct.Close();
                    Form4 frm4 = new Form4();
                    this.Hide();
                    frm4.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Choose Please");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.ShowDialog();
        }
    }
}
