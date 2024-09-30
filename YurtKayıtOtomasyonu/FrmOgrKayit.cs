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

namespace YurtKayıtOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void Form1_Load(object sender, EventArgs e)
        {
            // Bölümleri listeleme Komutları
            
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", bgl.bağlanti());
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                comboBoxBolum.Items.Add(oku[0].ToString());
            }
            bgl.bağlanti().Close();

            //Boş odaları listleme komutları
            
            SqlCommand komut2 = new SqlCommand("Select OdaNo from Odalar where OdaKapasite != OdaAktif", bgl.bağlanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                comboBoxOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.bağlanti().Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci (OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrAdres)values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.bağlanti());
                komutkaydet.Parameters.AddWithValue("@p1", TxtOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", MskTxtTc.Text);
                komutkaydet.Parameters.AddWithValue("@p4", MskTxtTelNo.Text);
                komutkaydet.Parameters.AddWithValue("@p5", MskTxtDogum.Text);
                komutkaydet.Parameters.AddWithValue("@p6", comboBoxBolum.Text);
                komutkaydet.Parameters.AddWithValue("@p7", TxtMail.Text);
                komutkaydet.Parameters.AddWithValue("@p8", comboBoxOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@p9", TxtVeliAdSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p10", maskedTextBoxVeliTel.Text);
                komutkaydet.Parameters.AddWithValue("@p11", richTextBoxAdres.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.bağlanti().Close();
                MessageBox.Show("Kayıt Başarılı...");

               //Ogr idyi Labela çekme
                
                SqlCommand komut = new SqlCommand("select Ogrid from Ogrenci" , bgl.bağlanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text = oku[0].ToString();

                }
                bgl.bağlanti().Close();




                // Öğrenci Borç Alanı Oluşturma
                SqlCommand komutkaydet2 = new SqlCommand("insert into Borclar  (Ogrid, OgrAd, OgrSoyad) values (@b1,@b2,@b3)", bgl.bağlanti());
                komutkaydet2.Parameters.AddWithValue("@b1", label12.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", TxtOgrAd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3" , TxtOgrSoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.bağlanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("HATA!! Lütfen Tekrar Deneyin");                                                    
            }

            //Öğrenci Oda Kontenjanı Azaltma

            SqlCommand komut1 = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNo =@oda1", bgl.bağlanti());
            komut1.Parameters.AddWithValue("@oda1", comboBoxOdaNo.Text);
            komut1.ExecuteNonQuery();
            bgl.bağlanti().Close() ;
             
        }
    }
}
//        Data Source = DESKTOP - 0OEVPEH\SQLEXPRESS;Initial Catalog = YurtOtomasyon; Integrated Security = True