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
    public partial class FrmGiderGüncelle : Form
    {
        public FrmGiderGüncelle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        public string id, elektrik, su, doğalgaz, internet, gıda, personel, diğer;

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Giderler set Elektrik=@p2,Su=@p3,Doğalgaz=@p4,İnternet=@p5,Gıda=@p6,Personel=@p7,Diger=@p8 where Odemeid=@p1", bgl.bağlanti());
                komut.Parameters.AddWithValue("@p1", Txtİd.Text);
                komut.Parameters.AddWithValue("@p2", TxtElektrik.Text);
                komut.Parameters.AddWithValue("@p3", TxtSu.Text);
                komut.Parameters.AddWithValue("@p4", TxtDoğalgaz.Text);
                komut.Parameters.AddWithValue("@p5", Txtİnternet.Text);
                komut.Parameters.AddWithValue("@p6", TxtGıda.Text);
                komut.Parameters.AddWithValue("@p7", TxtPersonel.Text);
                komut.Parameters.AddWithValue("@p8", TxtDiğer.Text);
                komut.ExecuteNonQuery();
                bgl.bağlanti().Close();
                MessageBox.Show("Güncelleme Başarılı");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Tekrar Deneyin...");
            }
        }

        private void FrmGiderGüncelle_Load(object sender, EventArgs e)
        {
            Txtİd.Text = id;
            TxtElektrik.Text = elektrik;
            TxtSu.Text = su;
            TxtDoğalgaz.Text = doğalgaz;
            Txtİnternet.Text = internet;
            TxtGıda.Text = gıda;
            TxtPersonel.Text = personel;
            TxtDiğer.Text = diğer;
        }
    }
}
