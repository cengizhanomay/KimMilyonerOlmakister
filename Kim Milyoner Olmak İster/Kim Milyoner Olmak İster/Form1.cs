using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kim_Milyoner_Olmak_İster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1şarkı.Ctlcontrols.stop();
            Form2 oyun = new Form2();
            oyun.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form1şarkı.Ctlcontrols.stop();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grpyazı1.Location = new Point(111, 24);
            grpyazı1.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grpyazı.Location = new Point(141, 83);
            grpyazı.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form1şarkı.URL = "anamüzik.mp3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            grpyazı1.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            grpyazı.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }
    }
}
