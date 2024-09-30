using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ZK_PANSİYON_VE_DİNLENME_TESİSİ
{
    public partial class Frm_Musteri : Form
    {
        public Frm_Musteri()
        {
            InitializeComponent();
        }
        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-0OEVPEH\\SQLEXPRESS;Initial Catalog=ZkPansiyon;Integrated Security=True");
        private void Btn101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda101 (Adi,Soyadi) values('" + TxtAD.Text + "', '" + TxtSOYAD.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();

        }

        private void Btn102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda102 (Adi,Soyadi) values('" + TxtAD.Text + "', '" + TxtSOYAD.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
        }

        private void Btn103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda103 (Adi,Soyadi) values('" + TxtAD.Text + "', '" + TxtSOYAD.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
        }

        private void Btn104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda104 (Adi,Soyadi) values('" + TxtAD.Text + "', '" + TxtSOYAD.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
        }

        private void Btn105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda105 (Adi,Soyadi) values('" + TxtAD.Text + "', '" + TxtSOYAD.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
        }

        private void Btn106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda106 (Adi,Soyadi) values('" + TxtAD.Text + "', '" + TxtSOYAD.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
        }

        private void Btn107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda107 (Adi,Soyadi) values('" + TxtAD.Text + "', '" + TxtSOYAD.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
        }

        private void Btn108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda108 (Adi,Soyadi) values('" + TxtAD.Text + "', '" + TxtSOYAD.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
        }

        private void Btn109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda109 (Adi,Soyadi) values('" + TxtAD.Text + "', '" + TxtSOYAD.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
        }

        private void BtnBOŞ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YEŞİL RENKLİ BUTONLAR BOŞ ODALARI GÖSTERİR...");
        }

        private void BtnDOLU_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KIRMIZI RENKLİ BUTONLAR DOLU ODALARI GÖSTERİR...");
        }

        private void dateTimePickerÇıkış_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(dateTimePickerGiriş.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dateTimePickerÇıkış.Text);
            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;
            label11.Text = Sonuc.TotalDays.ToString();
            Ucret = Convert.ToInt32(label11.Text) * 1500;
            TxtÜcret.Text = Ucret.ToString();
        }

        private void BtnKAYDET_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand komut = new SqlCommand(" insert into MüsteriEkle(Adi, Soyadi, Cinsiyet, Telefon, Mail, TC, OdaNO, Ucret, GirisTarihi, CikisTarihi ) values ('" + TxtAD.Text + "' ,'" + TxtSOYAD.Text + "' , '" + comboBox1.Text + "' , '" + maskedTxtTel.Text + "' ,'" + TxtMail.Text + "', '" + maskedTxtTC.Text + "',  '" +  TxtOdaNo.Text+ "' , '" + TxtÜcret.Text + "' , '" + dateTimePickerGiriş.Value.ToString("yyyy-MM-dd") + "' , '" + dateTimePickerÇıkış.Value.ToString("yyyy-MM-dd") + "') ", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
            MessageBox.Show("KAYIT İŞLEMİ BAŞARILI...");
        }

        private void Frm_Musteri_Load(object sender, EventArgs e)
        {

            bağlanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", bağlanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                Btn101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            bağlanti.Close();
            if (Btn101.Text != "101")
            {
                Btn101.BackColor = Color.Red;
                Btn101.Enabled = false;
            }


            bağlanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", bağlanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                Btn102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            bağlanti.Close();
            if (Btn102.Text != "102")
            {
                Btn102.BackColor = Color.Red;
                Btn102.Enabled = false;
            }


            bağlanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", bağlanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                Btn103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            bağlanti.Close();
            if (Btn103.Text != "103")
            {
                Btn103.BackColor = Color.Red;
                Btn103.Enabled = false;
            }


            bağlanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", bağlanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                Btn104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            bağlanti.Close();
            if (Btn104.Text != "104")
            {
                Btn104.BackColor = Color.Red;
                Btn104.Enabled = false;
            }



            bağlanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", bağlanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                Btn105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            bağlanti.Close();
            if (Btn105.Text != "105")
            {
                Btn105.BackColor = Color.Red;
                Btn105.Enabled = false;
            }


            bağlanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda106", bağlanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                Btn106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            bağlanti.Close();
            if (Btn106.Text != "106")
            {
                Btn106.BackColor = Color.Red;
                Btn106.Enabled = false;
            }


            bağlanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda107", bağlanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                Btn107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            bağlanti.Close();
            if (Btn107.Text != "107")
            {
                Btn107.BackColor = Color.Red;
                Btn107.Enabled = false;
            }


            bağlanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda108", bağlanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                Btn108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            bağlanti.Close();
            if (Btn108.Text != "108")
            {
                Btn108.BackColor = Color.Red;
                Btn108.Enabled = false;
            }


            bağlanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda109", bağlanti);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                Btn109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            bağlanti.Close();
            if (Btn109.Text != "109")
            {
                Btn109.BackColor = Color.Red;
                Btn109.Enabled = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TxtÜcret_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=DESKTOP-0OEVPEH\SQLEXPRESS;Initial Catalog=ZkPansiyon;Integrated Security=True;Trust Server Certificate=True