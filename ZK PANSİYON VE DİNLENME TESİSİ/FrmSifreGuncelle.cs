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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZK_PANSİYON_VE_DİNLENME_TESİSİ
{
    public partial class FrmSifreGuncelle : Form
    {
        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-0OEVPEH\\SQLEXPRESS;Initial Catalog=ZkPansiyon;Integrated Security=True");
        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand komut = new SqlCommand(" update AdminGiris set Kullanici='" + TxtKullaniciAdi.Text + "',Şifre='" + TxtSifre.Text + "'", bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close();
          
            MessageBox.Show("Güncelleme Başarıyla Yapıldı...");
        }

        private void FrmSifreGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
