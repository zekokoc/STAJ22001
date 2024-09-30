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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-0OEVPEH\\SQLEXPRESS;Initial Catalog=ZkPansiyon;Integrated Security=True");
        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            lblMaas.Text = (personel * 17000).ToString();

            int sonuc; 
            sonuc = Convert.ToInt32(lblToplam.Text) - (Convert.ToInt32(lblMaas.Text)+ Convert.ToInt32(lblÜRÜN1.Text)+Convert.ToInt32(lblÜRÜN2.Text)+Convert.ToInt32(lblÜRÜN3.Text)+Convert.ToInt32(lblFatura1.Text)+Convert.ToInt32(lblFatura2.Text)+Convert.ToInt32(lblFatura3.Text));
            lblSonuç.Text= sonuc.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblMaas_Click(object sender, EventArgs e)
        {

        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            // Kasadaki Toplam Tutar -Ücret-
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(Ucret) as toplam from MüsteriEkle", bağlanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblToplam.Text = oku["toplam"].ToString();
            }
            bağlanti.Close();



            // Gıda Giderleri

            bağlanti.Open();
            SqlCommand komut2 = new SqlCommand("Select sum(Gıda) as toplam1 from Stok", bağlanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblÜRÜN1.Text = oku2["toplam1"].ToString();
            }
            bağlanti.Close();

            // İçecek Giderleri

            bağlanti.Open();
            SqlCommand komut3 = new SqlCommand("Select sum(İcecek) as toplam2 from Stok", bağlanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblÜRÜN2.Text = oku3["toplam2"].ToString();
            }
            bağlanti.Close();

            //Çerez Giderleri


            bağlanti.Open();
            SqlCommand komut4 = new SqlCommand("Select sum(Cerezler) as toplam3 from Stok", bağlanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblÜRÜN3.Text = oku4["toplam3"].ToString();
            }
            bağlanti.Close();

            //Elektrik Fatura Gideri


            bağlanti.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(Elektrik) as toplam4 from Faturalar", bağlanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                lblFatura1.Text = oku5["toplam4"].ToString();
            }
            bağlanti.Close();


            //Su Fatura Gideri


            bağlanti.Open();
            SqlCommand komut6 = new SqlCommand("Select sum(Su) as toplam5 from Faturalar", bağlanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                lblFatura2.Text = oku6["toplam5"].ToString();
            }
            bağlanti.Close();


            //İnternet Fatura Gideri


            bağlanti.Open();
            SqlCommand komut7 = new SqlCommand("Select sum(İnternet) as toplam6 from Faturalar", bağlanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                lblFatura3.Text = oku7["toplam6"].ToString();
            }
            bağlanti.Close();



        }

    }
}
