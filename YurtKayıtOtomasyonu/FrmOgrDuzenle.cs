using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace YurtKayıtOtomasyonu
{
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        public string id,ad,soyad,TC,telefon,doğum,bölüm,mail,odano,veliad,velitel,adres;

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Ogrenci where Ogrid = @k1", bgl.bağlanti());
            komut.Parameters.AddWithValue("@k1", TxtOgrid.Text);
            komut.ExecuteNonQuery();
            bgl.bağlanti().Close();
            MessageBox.Show("Öğrenci Silindi..");

            //Oda Kontenjanı Arttırma

            SqlCommand komutoda = new SqlCommand("update odalar set OdaAktif = OdaAktif-1  where OdaNo=@oda", bgl.bağlanti());
            komutoda.Parameters.AddWithValue("@oda", comboBoxOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.bağlanti().Close();

        }
        

        

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p2,OgrSoyad=@p3,OgrTc=@p4,OgrTelefon=@p5,OgrDogum=@p6,OgrBolum =@p7,OgrMail=@p8,OgrOdaNo=@p9,OgrVeliAdSoyad=@p10,OgrVeliTelefon=@p11,OgrAdres=@p12 where Ogrid=@p1", bgl.bağlanti());
                komut.Parameters.AddWithValue("@p1", TxtOgrid.Text);
                komut.Parameters.AddWithValue("@p2", TxtOgrAd.Text);
                komut.Parameters.AddWithValue("@p3", TxtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", MskTxtTc.Text);
                komut.Parameters.AddWithValue("@p5", MskTxtTelNo.Text);
                komut.Parameters.AddWithValue("@p6", MskTxtDogum.Text);
                komut.Parameters.AddWithValue("@p7", comboBoxBolum.Text);
                komut.Parameters.AddWithValue("@p8", TxtMail.Text);
                komut.Parameters.AddWithValue("@p9", comboBoxOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", TxtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p11", maskedTextBoxVeliTel.Text);
                komut.Parameters.AddWithValue("@p12", richTextBoxAdres.Text);
                komut.ExecuteNonQuery();
                bgl.bağlanti().Close();
                MessageBox.Show("Güncelleme Başarılı...");
            }
            catch (Exception)
            {
                  MessageBox.Show("Hata Yeniden Deneyin...");
            }


        }

        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            TxtOgrid.Text = id;
            TxtOgrAd.Text = ad;
            TxtOgrSoyad.Text = soyad;   
            MskTxtTc.Text = TC;
            MskTxtTelNo.Text = telefon;
            MskTxtDogum.Text = doğum;
            comboBoxBolum.Text= bölüm;
            TxtMail.Text = mail;
            comboBoxOdaNo.Text=odano;
            TxtVeliAdSoyad.Text = veliad;
            maskedTextBoxVeliTel.Text = velitel;
            richTextBoxAdres.Text = adres;

        }
    }
}
