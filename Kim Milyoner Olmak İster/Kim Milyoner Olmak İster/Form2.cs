using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kim_Milyoner_Olmak_İster
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection bağlan = new SqlConnection("Data Source=DESKTOP;Initial Catalog=ilkbilgiyarışması;Integrated Security=True");

        int soru;
        int zaman;

        private void şıklaraktif()
        {
            btnbaşla.Enabled = false;
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
        }

        private void şıklarpasif()
        {
            btnbaşla.Enabled = true;
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
        }

        private void butonlarsiyah()
        {
            btna.BackColor = Color.Black;
            btnb.BackColor = Color.Black;
            btnc.BackColor = Color.Black;
            btnd.BackColor = Color.Black;
        }

        private void butonlarsarı()
        {
            btna.BackColor = Color.Yellow;
            btnb.BackColor = Color.Yellow;
            btnc.BackColor = Color.Yellow;
            btnd.BackColor = Color.Yellow;
        }

        private void butonyazırengibeyaz()
        {
            btna.ForeColor = Color.White;
            btnb.ForeColor = Color.White;
            btnc.ForeColor = Color.White;
            btnd.ForeColor = Color.White;
        }

        private void ışıkgörünür()
        {
            pctrışık.Visible = true;
            pctrışık.Enabled = true;
        }

        private void ışıkgörünmez()
        {
            pctrışık.Visible = false;
            pctrışık.Enabled = false;
        }

        private void btna_Click(object sender, EventArgs e)
        {
            pctrjoker.Visible = false;
            grptelefoncevap.Visible = false;
            tmrsüre.Enabled = false;
            btnseyirci.Enabled = false;
            btntelefon.Enabled = false;
            btnyüzde.Enabled = false;
            butonyazırengibeyaz();
            if (btna.Text == lblcevap.Text)
            {
                if (soru == 1)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 2)
                {
                    mediaplayeroyun.URL = "barajdoğru.mp3";
                }
                if (soru == 3)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 4)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 5)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 6)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 7)
                {
                    mediaplayeroyun.URL = "barajdoğru.mp3";
                }
                if (soru == 8)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 9)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 10)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 11)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 12)
                {
                    mediaplayeroyun.URL = "barajdoğru.mp3";
                }


                btna.BackColor = Color.Green;
                butonyazırengibeyaz();
                ışıkgörünür();
            }
            else
            {
                if (soru == 1)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Yarışmayı kaybettiniz ve hiç para kazanamadınız ...";
                }
                if (soru == 2)
                {
                    mediaplayeroyun.URL = "barajyanlış.mp3";
                    sorukısmı.Text = "Yarışmayı kaybettiniz ve hiç para kazanamadınız ...";
                }
                if (soru == 3)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 1.000 TL para kazandınız...";
                }
                if (soru == 4)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 1.000 TL para kazandınız...";
                }
                if (soru == 5)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 1.000 TL para kazandınız...";
                }
                if (soru == 6)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 1.000 TL para kazandınız...";
                }
                if (soru == 7)
                {
                    mediaplayeroyun.URL = "barajyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 1.000 TL para kazandınız...";
                }
                if (soru == 8)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 15.000 TL para kazandınız...";
                }
                if (soru == 9)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 15.000 TL para kazandınız...";
                }
                if (soru == 10)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 15.000 TL para kazandınız...";
                }
                if (soru == 11)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 15.000 TL para kazandınız...";
                }
                if (soru == 12)
                {
                    mediaplayeroyun.URL = "barajyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 15.000 TL para kazandınız...";
                }

                btna.BackColor = Color.Red;
                btnbaşla.Visible = false;
                butonyazırengibeyaz();
                ışıkgörünmez();
                button1.Enabled = false;
                if (lblcevap.Text == btnd.Text)
                {
                    btnd.BackColor = Color.Green;
                }
                if (lblcevap.Text == btnb.Text)
                {
                    btnb.BackColor = Color.Green;
                }
                if (lblcevap.Text == btnc.Text)
                {
                    btnc.BackColor = Color.Green;
                }
            }
            şıklarpasif();
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            pctrjoker.Visible = false;
            grptelefoncevap.Visible = false;
            tmrsüre.Enabled = false;
            btnseyirci.Enabled = false;
            btntelefon.Enabled = false;
            btnyüzde.Enabled = false;
            butonyazırengibeyaz();
            if (btnb.Text == lblcevap.Text)
            {
                if (soru == 1)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 2)
                {
                    mediaplayeroyun.URL = "barajdoğru.mp3";
                }
                if (soru == 3)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 4)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 5)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 6)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 7)
                {
                    mediaplayeroyun.URL = "barajdoğru.mp3";
                }
                if (soru == 8)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 9)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 10)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 11)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 12)
                {
                    mediaplayeroyun.URL = "barajdoğru.mp3";
                }

                btnb.BackColor = Color.Green;
                butonyazırengibeyaz();
                ışıkgörünür();
            }
            else
            {
                if (soru == 1)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Yarışmayı kaybettiniz ve hiç para kazanamadınız ...";
                }
                if (soru == 2)
                {
                    mediaplayeroyun.URL = "barajyanlış.mp3";
                    sorukısmı.Text = "Yarışmayı kaybettiniz ve hiç para kazanamadınız ...";
                }
                if (soru == 3)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 1.000 TL para kazandınız...";
                }
                if (soru == 4)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 1.000 TL para kazandınız...";
                }
                if (soru == 5)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 1.000 TL para kazandınız...";
                }
                if (soru == 6)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 1.000 TL para kazandınız...";
                }
                if (soru == 7)
                {
                    mediaplayeroyun.URL = "barajyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 1.000 TL para kazandınız...";
                }
                if (soru == 8)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 15.000 TL para kazandınız...";
                }
                if (soru == 9)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 15.000 TL para kazandınız...";
                }
                if (soru == 10)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 15.000 TL para kazandınız...";
                }
                if (soru == 11)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 15.000 TL para kazandınız...";
                }
                if (soru == 12)
                {
                    mediaplayeroyun.URL = "barajyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 15.000 TL para kazandınız...";
                }

                btnb.BackColor = Color.Red;
                btnbaşla.Visible = false;
                butonyazırengibeyaz();
                ışıkgörünmez();
                button1.Enabled = false;
                if (lblcevap.Text == btna.Text)
                {
                    btna.BackColor = Color.Green;
                }
                if (lblcevap.Text == btnd.Text)
                {
                    btnd.BackColor = Color.Green;
                }
                if (lblcevap.Text == btnc.Text)
                {
                    btnc.BackColor = Color.Green;
                }
            }
            şıklarpasif();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            pctrjoker.Visible = false;
            grptelefoncevap.Visible = false;
            tmrsüre.Enabled = false;
            btnseyirci.Enabled = false;
            btntelefon.Enabled = false;
            btnyüzde.Enabled = false;
            butonyazırengibeyaz();
            if (btnc.Text == lblcevap.Text)
            {
                if (soru == 1)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 2)
                {
                    mediaplayeroyun.URL = "barajdoğru.mp3";
                }
                if (soru == 3)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 4)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 5)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 6)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 7)
                {
                    mediaplayeroyun.URL = "barajdoğru.mp3";
                }
                if (soru == 8)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 9)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 10)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 11)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 12)
                {
                    mediaplayeroyun.URL = "barajdoğru.mp3";
                }

                btnc.BackColor = Color.Green;
                butonyazırengibeyaz();
                ışıkgörünür();
            }
            else
            {
                if (soru == 1)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Yarışmayı kaybettiniz ve hiç para kazanamadınız ...";
                }
                if (soru == 2)
                {
                    mediaplayeroyun.URL = "barajyanlış.mp3";
                    sorukısmı.Text = "Yarışmayı kaybettiniz ve hiç para kazanamadınız ...";
                }
                if (soru == 3)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 1.000 TL para kazandınız..."; ;
                }
                if (soru == 4)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 1.000 TL para kazandınız...";
                }
                if (soru == 5)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 1.000 TL para kazandınız...";
                }
                if (soru == 6)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 1.000 TL para kazandınız...";
                }
                if (soru == 7)
                {
                    mediaplayeroyun.URL = "barajyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 1.000 TL para kazandınız...";
                }
                if (soru == 8)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 15.000 TL para kazandınız...";
                }
                if (soru == 9)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 15.000 TL para kazandınız...";
                }
                if (soru == 10)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 15.000 TL para kazandınız...";
                }
                if (soru == 11)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 15.000 TL para kazandınız...";
                }
                if (soru == 12)
                {
                    mediaplayeroyun.URL = "barajyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 15.000 TL para kazandınız...";
                }

                btnc.BackColor = Color.Red;
                btnbaşla.Visible = false;
                butonyazırengibeyaz();
                ışıkgörünmez();
                button1.Enabled = false;
                if (lblcevap.Text == btna.Text)
                {
                    btna.BackColor = Color.Green;
                }
                if (lblcevap.Text == btnb.Text)
                {
                    btnb.BackColor = Color.Green;
                }
                if (lblcevap.Text == btnd.Text)
                {
                    btnd.BackColor = Color.Green;
                }
            }
            şıklarpasif();
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            pctrjoker.Visible = false;
            grptelefoncevap.Visible = false;
            tmrsüre.Enabled = false;
            btnseyirci.Enabled = false;
            btntelefon.Enabled = false;
            btnyüzde.Enabled = false;
            butonyazırengibeyaz();
            if (btnd.Text == lblcevap.Text)
            {
                if (soru == 1)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 2)
                {
                    mediaplayeroyun.URL = "barajdoğru.mp3";
                }
                if (soru == 3)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 4)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 5)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 6)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 7)
                {
                    mediaplayeroyun.URL = "barajdoğru.mp3";
                }
                if (soru == 8)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 9)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 10)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 11)
                {
                    mediaplayeroyun.URL = "normaldoğru.mp3";
                }
                if (soru == 12)
                {
                    mediaplayeroyun.URL = "barajdoğru.mp3";
                }

                btnd.BackColor = Color.Green;
                butonyazırengibeyaz();
                ışıkgörünür();
            }
            else
            {
                if (soru == 1)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Yarışmayı kaybettiniz ve hiç para kazanamadınız ...";
                }
                if (soru == 2)
                {
                    mediaplayeroyun.URL = "barajyanlış.mp3";
                    sorukısmı.Text = "Yarışmayı kaybettiniz ve hiç para kazanamadınız ...";
                }
                if (soru == 3)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 1.000 TL para kazandınız..."; ;
                }
                if (soru == 4)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 1.000 TL para kazandınız...";
                }
                if (soru == 5)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 1.000 TL para kazandınız...";
                }
                if (soru == 6)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 1.000 TL para kazandınız...";
                }
                if (soru == 7)
                {
                    mediaplayeroyun.URL = "barajyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 1.000 TL para kazandınız...";
                }
                if (soru == 8)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 15.000 TL para kazandınız...";
                }
                if (soru == 9)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 15.000 TL para kazandınız...";
                }
                if (soru == 10)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 15.000 TL para kazandınız...";
                }
                if (soru == 11)
                {
                    mediaplayeroyun.URL = "normalyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 15.000 TL para kazandınız...";
                }
                if (soru == 12)
                {
                    mediaplayeroyun.URL = "barajyanlış.mp3";
                    sorukısmı.Text = "Soruyu cevaplayamadınız ve 15.000 TL para kazandınız...";
                }

                btnd.BackColor = Color.Red;
                btnbaşla.Visible = false;
                butonyazırengibeyaz();
                ışıkgörünmez();
                button1.Enabled = false;
                if (lblcevap.Text == btna.Text)
                {
                    btna.BackColor = Color.Green;
                }
                if (lblcevap.Text == btnb.Text)
                {
                    btnb.BackColor = Color.Green;
                }
                if (lblcevap.Text == btnc.Text)
                {
                    btnc.BackColor = Color.Green;
                }
            }
            şıklarpasif();
        }
        private void btnbaşla_Click(object sender, EventArgs e)
        {
            mediaplayeroyun.Ctlcontrols.stop();

            btnbaşla.Text = "İleri >";
            şıklaraktif();
            butonlarsiyah();
            soru++;
            lblsoru.Text = soru.ToString();
            ışıkgörünmez();

            btnseyirci.Enabled = true;
            btntelefon.Enabled = true;
            btnyüzde.Enabled = true;

            if (soru == 1)
            {
                zaman = 20;
                lblzaman.Text = zaman.ToString();
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru1 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    sorukısmı.Text = (oku["soru"].ToString());
                    lblcevap.Text = (oku["dogru"].ToString());
                    tmrsüre.Enabled = true;
                }
                bağlan.Close();
            }

            if (soru == 2)
            {
                btnparaileri.Location = new Point(711, 420);
                zaman = 20;
                lblzaman.Text = zaman.ToString();
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru2 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    sorukısmı.Text = (oku["soru"].ToString());
                    lblcevap.Text = (oku["dogru"].ToString());
                    tmrsüre.Enabled = true;
                }
                bağlan.Close();
            }

            if (soru == 3)
            {
                btnparaileri.Location = new Point(711, 388);
                zaman = 20;
                lblzaman.Text = zaman.ToString();
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru3 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    sorukısmı.Text = (oku["soru"].ToString());
                    lblcevap.Text = (oku["dogru"].ToString());
                    tmrsüre.Enabled = true;
                }
                bağlan.Close();
            }

            if (soru == 4)
            {
                btnparaileri.Location = new Point(711, 359);
                zaman = 25;
                lblzaman.Text = zaman.ToString();
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru4 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    sorukısmı.Text = (oku["soru"].ToString());
                    lblcevap.Text = (oku["dogru"].ToString());
                    tmrsüre.Enabled = true;
                }
                bağlan.Close();
            }

            if (soru == 5)
            {
                btnparaileri.Location = new Point(711, 329);
                zaman = 25;
                lblzaman.Text = zaman.ToString();
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru5 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    sorukısmı.Text = (oku["soru"].ToString());
                    lblcevap.Text = (oku["dogru"].ToString());
                    tmrsüre.Enabled = true;
                }
                bağlan.Close();
            }

            if (soru == 6)
            {
                btnparaileri.Location = new Point(711, 298);
                zaman = 25;
                lblzaman.Text = zaman.ToString();
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru6 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    sorukısmı.Text = (oku["soru"].ToString());
                    lblcevap.Text = (oku["dogru"].ToString());
                    tmrsüre.Enabled = true;
                }
                bağlan.Close();
            }

            if (soru == 7)
            {
                btnparaileri.Location = new Point(711, 267);
                zaman = 30;
                lblzaman.Text = zaman.ToString();
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru7 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    sorukısmı.Text = (oku["soru"].ToString());
                    lblcevap.Text = (oku["dogru"].ToString());
                    tmrsüre.Enabled = true;
                }
                bağlan.Close();
            }

            if (soru == 8)
            {
                btnparaileri.Location = new Point(711, 238);
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru8 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    sorukısmı.Text = (oku["soru"].ToString());
                    lblcevap.Text = (oku["dogru"].ToString());
                    tmrsüre.Enabled = false;
                    lblzaman.Visible = false;
                }
                bağlan.Close();
            }

            if (soru == 9)
            {
                btnparaileri.Location = new Point(711, 208);
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru9 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    sorukısmı.Text = (oku["soru"].ToString());
                    lblcevap.Text = (oku["dogru"].ToString());
                    tmrsüre.Enabled = false;
                    lblzaman.Visible = false;
                }
                bağlan.Close();
            }

            if (soru == 10)
            {
                btnparaileri.Location = new Point(711, 176);
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru10 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    sorukısmı.Text = (oku["soru"].ToString());
                    lblcevap.Text = (oku["dogru"].ToString());
                    tmrsüre.Enabled = false;
                    lblzaman.Visible = false;
                }
                bağlan.Close();
            }

            if (soru == 11)
            {
                btnparaileri.Location = new Point(711, 146);
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru11 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    sorukısmı.Text = (oku["soru"].ToString());
                    lblcevap.Text = (oku["dogru"].ToString());
                    tmrsüre.Enabled = false;
                    lblzaman.Visible = false;
                }
                bağlan.Close();
            }

            if (soru == 12)
            {
                btnparaileri.Location = new Point(711, 115);
                bağlan.Open();
                SqlCommand komut = new SqlCommand("Select *from soru12 order by NEWID()", bağlan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btna.Text = (oku["a"].ToString());
                    btnb.Text = (oku["b"].ToString());
                    btnc.Text = (oku["c"].ToString());
                    btnd.Text = (oku["d"].ToString());
                    sorukısmı.Text = (oku["soru"].ToString());
                    lblcevap.Text = (oku["dogru"].ToString());
                    tmrsüre.Enabled = false;
                    lblzaman.Visible = false;
                    btnbaşla.Text = "Bitir";
                }
                bağlan.Close();
            }
            if (soru == 13)
            {
                sorukısmı.Text = "Tebrikler !!! Yarışmayı kazandınız !!! Alacağınız para miktarı 1.000.000 TL'dir.";
                lblsoru.Text = "12";
                btnseyirci.Enabled = false;
                btntelefon.Enabled = false;
                btnyüzde.Enabled = false;
                seyircino.Enabled = false;
                telefonno.Enabled = false;
                yüzdeno.Enabled = false;
                btnbaşla.Visible = false;
                btna.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
                btna.Text = "";
                btnb.Text = "";
                btnc.Text = "";
                btnd.Text = "";

            }

        }

        private void tmrsüre_Tick(object sender, EventArgs e)
        {
            zaman = zaman - 1;
            lblzaman.Text = zaman.ToString();

            if (zaman == 0)
            {
                ışıkgörünmez();
                button1.Enabled = false;
                btnseyirci.Enabled = false;
                btntelefon.Enabled = false;
                btnyüzde.Enabled = false;
                seyircino.Enabled = false;
                telefonno.Enabled = false;
                yüzdeno.Enabled = false;
                tmrsüre.Enabled = false;
                butonlarsarı();
                şıklarpasif();
                btnbaşla.Visible = false;
                pctrjoker.Visible = false;
                grptelefoncevap.Visible = false;

                if (soru == 1)
                {
                    sorukısmı.Text = "Süre doldu verilen süre içerisinde soruyu çevaplayamadınız ve yarışmayı kaybettiniz ...";
                }
                if (soru == 2)
                {
                    sorukısmı.Text = "Süre doldu verilen süre içerisinde soruyu çevaplayamadınız ve yarışmadan 500 TL para kazandınız ...";
                }
                if (soru == 3)
                {
                    sorukısmı.Text = "Süre doldu verilen süre içerisinde soruyu çevaplayamadınız ve yarışmadan 1.000 TL para kazandınız ...";
                }
                if (soru == 4)
                {
                    sorukısmı.Text = "Süre doldu verilen süre içerisinde soruyu çevaplayamadınız ve yarışmadan 1.000 TL para kazandınız ...";
                }
                if (soru == 5)
                {
                    sorukısmı.Text = "Süre doldu verilen süre içerisinde soruyu çevaplayamadınız ve yarışmadan 1.000 TL para kazandınız ...";
                }
                if (soru == 6)
                {
                    sorukısmı.Text = "Süre doldu verilen süre içerisinde soruyu çevaplayamadınız ve yarışmadan 1.000 TL para kazandınız ...";
                }
                if (soru == 7)
                {
                    sorukısmı.Text = "Süre doldu verilen süre içerisinde soruyu çevaplayamadınız ve yarışmadan 1.000 TL para kazandınız ...";
                }

                if (btna.Text == lblcevap.Text)
                {
                    btna.BackColor = Color.Green;
                    butonyazırengibeyaz();
                }

                if (btnb.Text == lblcevap.Text)
                {
                    btnb.BackColor = Color.Green;
                    butonyazırengibeyaz();
                }

                if (btnc.Text == lblcevap.Text)
                {
                    btnc.BackColor = Color.Green;
                    butonyazırengibeyaz();
                }

                if (btnd.Text == lblcevap.Text)
                {
                    btnd.BackColor = Color.Green;
                    butonyazırengibeyaz();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            şıklarpasif();
        }

        private void btnseyirci_Click(object sender, EventArgs e)
        {
            btnseyirci.Enabled = false;
            btnseyirci.Visible = false;
            seyircino.Visible = true;
            pctrjoker.Visible = true;
            grptelefoncevap.Visible = false;

            if (btna.Text == lblcevap.Text)
            {
                pctrjoker.ImageLocation = "seyircicevapa.jpg";
            }

            if (btnb.Text == lblcevap.Text)
            {
                pctrjoker.ImageLocation = "seyircicevapb.jpg";
            }

            if (btnc.Text == lblcevap.Text)
            {
                pctrjoker.ImageLocation = "seyircicevapc.jpg";
            }

            if (btnd.Text == lblcevap.Text)
            {
                pctrjoker.ImageLocation = "seyircicevapd.jpg";
            }
        }

        private void btntelefon_Click(object sender, EventArgs e)
        {
            btntelefon.Enabled = false;
            btntelefon.Visible = false;
            telefonno.Visible = true;
            pctrjoker.Visible = true;
            pctrjoker.ImageLocation = "telefon.jpg";
            grptelefoncevap.Visible = true;

            if (btna.Text == lblcevap.Text)
            {
                txbtelefoncevap.Text = "Doğru cevap a şıkkı.";
            }

            if (btnb.Text == lblcevap.Text)
            {
                txbtelefoncevap.Text = "Doğru cevap b şıkkı.";
            }

            if (btnc.Text == lblcevap.Text)
            {
                txbtelefoncevap.Text = "Doğru cevap c şıkkı.";
            }

            if (btnd.Text == lblcevap.Text)
            {
                txbtelefoncevap.Text = "Doğru cevap d şıkkı.";
            }
        }

        private void btnonayla_Click(object sender, EventArgs e)
        {
            lbltelefonad.Text = txbtelefonad.Text;
            lblad.Text = txbkendiad.Text;
            seçimekranı.Visible = false;
            btnbaşla.Enabled = true;
        }

        private void btnyüzde_Click(object sender, EventArgs e)
        {
            btnyüzde.Enabled = false;
            btnyüzde.Visible = false;
            yüzdeno.Visible = true;

            if (btna.Text != lblcevap.Text && btnb.Text != lblcevap.Text)
            {
                btna.BackColor = Color.Red;
                btnb.BackColor = Color.Red;
                butonyazırengibeyaz();
            }
            else

                if (btna.Text != lblcevap.Text && btnc.Text != lblcevap.Text)
                {
                    btna.BackColor = Color.Red;
                    btnc.BackColor = Color.Red;
                    butonyazırengibeyaz();
                }
                else

                    if (btna.Text != lblcevap.Text && btnd.Text != lblcevap.Text)
                    {
                        btna.BackColor = Color.Red;
                        btnd.BackColor = Color.Red;
                        butonyazırengibeyaz();
                    }
                    else

                        if (btnb.Text != lblcevap.Text && btna.Text != lblcevap.Text)
                        {
                            btna.BackColor = Color.Red;
                            btnc.BackColor = Color.Red;
                            butonyazırengibeyaz();
                        }
                        else

                            if (btnb.Text != lblcevap.Text && btnc.Text != lblcevap.Text)
                            {
                                btnb.BackColor = Color.Red;
                                btnc.BackColor = Color.Red;
                                butonyazırengibeyaz();
                            }
                            else
                                if (btnb.Text != lblcevap.Text && btnd.Text != lblcevap.Text)
                                {
                                    btnb.BackColor = Color.Red;
                                    btnd.BackColor = Color.Red;
                                    butonyazırengibeyaz();
                                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btntamekran_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (lblcevap.Text == btnd.Text)
            {
                btnd.BackColor = Color.Green;
                btnd.Text = lblcevap.Text;
                butonyazırengibeyaz();
            }
            if (lblcevap.Text == btnb.Text)
            {
                btnb.BackColor = Color.Green;
                btnb.Text = lblcevap.Text;
                butonyazırengibeyaz();
            }
            if (lblcevap.Text == btnc.Text)
            {
                btnc.BackColor = Color.Green;
                btnc.Text = lblcevap.Text;
                butonyazırengibeyaz();
            }
            if (lblcevap.Text == btna.Text)
            {
                btna.BackColor = Color.Green;
                btna.Text = lblcevap.Text;
                butonyazırengibeyaz();
            }
            tmrsüre.Enabled = false;
            btnseyirci.Enabled = false;
            btntelefon.Enabled = false;
            btnyüzde.Enabled = false;
            seyircino.Enabled = false;
            telefonno.Enabled = false;
            yüzdeno.Enabled = false;
            btnbaşla.Visible = false;
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            if (soru == 1)
            {
                sorukısmı.Text = "Yarışmadan çekildiniz !!! Kazandığınız para 0 TL'dir.";
            }
            if (soru == 2)
            {
                sorukısmı.Text = "Yarışmadan çekildiniz !!! Kazandığınız para 500 TL'dir.";
            }
            if (soru == 3)
            {
                sorukısmı.Text = "Yarışmadan çekildiniz !!! Kazandığınız para 1.000 TL'dir.";
            }
            if (soru == 4)
            {
                sorukısmı.Text = "Yarışmadan çekildiniz !!! Kazandığınız para 2.000 TL'dir.";
            }
            if (soru == 5)
            {
                sorukısmı.Text = "Yarışmadan çekildiniz !!! Kazandığınız para 3.000 TL'dir.";
            }
            if (soru == 6)
            {
                sorukısmı.Text = "Yarışmadan çekildiniz !!! Kazandığınız para 5.000 TL'dir.";
            }
            if (soru == 7)
            {
                sorukısmı.Text = "Yarışmadan çekildiniz !!! Kazandığınız para 7.500 TL'dir.";
            }
            if (soru == 8)
            {
                sorukısmı.Text = "Yarışmadan çekildiniz !!! Kazandığınız para 15.000 TL'dir.";
            }
            if (soru == 9)
            {
                sorukısmı.Text = "Yarışmadan çekildiniz !!! Kazandığınız para 30.000 TL'dir.";
            }
            if (soru == 10)
            {
                sorukısmı.Text = "Yarışmadan çekildiniz !!! Kazandığınız para 60.000 TL'dir.";
            }
            if (soru == 11)
            {
                sorukısmı.Text = "Yarışmadan çekildiniz !!! Kazandığınız para 125.000 TL'dir.";
            }
            if (soru == 12)
            {
                sorukısmı.Text = "Yarışmadan çekildiniz !!! Kazandığınız para 250.000 TL'dir.";
            }
        }
    }
}
