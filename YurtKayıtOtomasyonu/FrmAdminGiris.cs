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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim(); 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from admin  where YoneticiAd = @p1 and YoneticiSifre=@p2",bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1", TxtKullanıcı.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre...");
                TxtKullanıcı.Clear();
                TxtSifre.Clear();
                TxtKullanıcı.Focus();

            }
            bgl.bağlanti().Close();
            
           
        }
    }
}
