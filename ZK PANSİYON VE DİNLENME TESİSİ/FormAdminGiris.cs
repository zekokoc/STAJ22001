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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-0OEVPEH\\SQLEXPRESS;Initial Catalog=ZkPansiyon;Integrated Security=True");
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                bağlanti.Open();
                string sql = "select * from AdminGiris where Kullanici =@Kullaniciadi AND Şifre = @Sifresi";
                SqlParameter prm1 = new SqlParameter ("Kullaniciadi", TxtKullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter ("Sifresi", TxtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand (sql,bağlanti);
                komut.Parameters.Add (prm1);
                komut.Parameters.Add (prm2);

                DataTable dt = new DataTable ();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill (dt);
                if(dt.Rows.Count > 0)
                {
                    ANAFORM fr = new ANAFORM();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş!!!");
            }
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {
             
        }
    }
}
