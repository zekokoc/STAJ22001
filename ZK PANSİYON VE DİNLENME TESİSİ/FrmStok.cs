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
using System.Drawing.Text;
namespace ZK_PANSİYON_VE_DİNLENME_TESİSİ
{
    public partial class FrmStok : Form
    {
        public FrmStok()
        {
            InitializeComponent();
        }
        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-0OEVPEH\\SQLEXPRESS;Initial Catalog=ZkPansiyon;Integrated Security=True");

        private void veriler()
        {
            listView1.Items.Clear();
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("select  * from Stok", bağlanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gıda"].ToString();
                ekle.SubItems.Add(oku["İcecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            bağlanti.Close();
        }
        private void veriler2()
        {
            listView2.Items.Clear();
            bağlanti.Open();
            SqlCommand komut2 = new SqlCommand("select  * from Faturalar", bağlanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["İnternet"].ToString());
                listView2.Items.Add(ekle);
            }
            bağlanti.Close();
        }

                private void BtnKaydet1_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stok (Gıda,İcecek,Cerezler) values ('"+TxtGıdalar.Text + "' , '"+TxtAtıştırma.Text+"','"+Txtİçecekler.Text+"')",bağlanti);
            komut.ExecuteNonQuery();
            bağlanti .Close();
            veriler();
          
        }

        private void FrmStok_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2 ();
        }

        private void BtnKaydet2_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Faturalar (Elektrik,Su,İnternet) values ('" + TxtElektrik.Text + "' , '" + TxtSu.Text + "','" + Txtİnternet.Text + "')", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
            veriler2();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
