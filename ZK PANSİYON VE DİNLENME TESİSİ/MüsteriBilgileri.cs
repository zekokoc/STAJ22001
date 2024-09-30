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
    public partial class MüsteriBilgileri : Form
    {
        public MüsteriBilgileri()
        {
            InitializeComponent();
        }
        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-0OEVPEH\\SQLEXPRESS;Initial Catalog=ZkPansiyon;Integrated Security=True");
        private void verilerigoster()
            
        {
            listView1.Items.Clear();
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("select * from MüsteriEkle" , bağlanti);
            SqlDataReader oku = komut.ExecuteReader();
            
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Müsteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);


            }
            bağlanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TxtÜcret_TextChanged(object sender, EventArgs e)
        {

        }

        private void MüsteriBilgileri_Load(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAD.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSOYAD.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            maskedTxtTel.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            maskedTxtTC.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtÜcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
           dateTimePickerGiriş.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dateTimePickerÇıkış.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if(TxtOdaNo.Text == "101")
            {
                bağlanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda101", bağlanti);
                komut.ExecuteNonQuery();
                bağlanti.Close();
                verilerigoster();
                MessageBox.Show("Silme Başarılı...");
            }
            if (TxtOdaNo.Text == "102")
            {
                bağlanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda102", bağlanti);
                komut.ExecuteNonQuery();
                bağlanti.Close();
                verilerigoster();
                MessageBox.Show("Silme Başarılı...");
            }
            if (TxtOdaNo.Text == "103")
            {
                bağlanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda103", bağlanti);
                komut.ExecuteNonQuery();
                bağlanti.Close();
                verilerigoster();
                MessageBox.Show("Silme Başarılı...");
            }
            if (TxtOdaNo.Text == "104")
            {
                bağlanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda104", bağlanti);
                komut.ExecuteNonQuery();
                bağlanti.Close();
                verilerigoster();
                MessageBox.Show("Silme Başarılı...");
            }
            if (TxtOdaNo.Text == "105")
            {
                bağlanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda105", bağlanti);
                komut.ExecuteNonQuery();
                bağlanti.Close();
                verilerigoster();
                MessageBox.Show("Silme Başarılı...");
            }
            if (TxtOdaNo.Text == "106")
            {
                bağlanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda106", bağlanti);
                komut.ExecuteNonQuery();
                bağlanti.Close();
                verilerigoster();
                MessageBox.Show("Silme Başarılı...");
            }
            if (TxtOdaNo.Text == "107")
            {
                bağlanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda107", bağlanti);
                komut.ExecuteNonQuery();
                bağlanti.Close();
                verilerigoster();
                MessageBox.Show("Silme Başarılı...");
            }
            if (TxtOdaNo.Text == "108")
            {
                bağlanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda108", bağlanti);
                komut.ExecuteNonQuery();
                bağlanti.Close();
                verilerigoster();
                MessageBox.Show("Silme Başarılı...");
            }
            if (TxtOdaNo.Text == "109")
            {
                bağlanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda109", bağlanti);
                komut.ExecuteNonQuery();
                bağlanti.Close();
                verilerigoster();
                MessageBox.Show("Silme Başarılı...");
            }
           

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAD.Clear();
            TxtSOYAD.Clear();
            comboBox1.Text = "";
            maskedTxtTel.Clear();
            TxtMail.Clear();
            maskedTxtTC.Clear();
            TxtOdaNo.Clear();
            TxtÜcret.Clear();
            dateTimePickerGiriş.Text = "";
            dateTimePickerÇıkış.Text = "";
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand komut = new SqlCommand(" update MüsteriEkle set Adi='"+TxtAD.Text+"',Soyadi='"+TxtSOYAD.Text+"',Cinsiyet= '"+comboBox1.Text+"',Telefon='"+maskedTxtTel.Text+ "',Mail='"+TxtMail.Text+ "',TC='"+maskedTxtTC.Text+ "',OdaNo='"+TxtOdaNo.Text+ "',Ucret='"+TxtÜcret.Text+ "' , GirisTarihi='"+dateTimePickerGiriş.Value.ToString("yyyy-MM-dd")+ "',CikisTarihi='"+dateTimePickerÇıkış.Value.ToString("yyyy-MM-dd")+"'where Müsteriid=" + id+"",bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
            verilerigoster();
            MessageBox.Show("Güncelleme Başarıyla Yapıldı...");
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("select * from MüsteriEkle where Adi like '%" +textBox1.Text+"%'", bağlanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Müsteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);


            }
            bağlanti.Close();
        }
    }
}
// SqlCommand komut = new SqlCommand("delete from MüsteriEkle where Müsteriid=("+id+")",bağlanti);