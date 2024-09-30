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
    public partial class FrmGelirİstatistik : Form
    {
        public FrmGelirİstatistik()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmGelirİstatistik_Load(object sender, EventArgs e)
        {
            //Kasadaki Toplam Tutar

            SqlCommand komut = new SqlCommand("Select Sum(OdemeMiktar) from Kasa ", bgl.bağlanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                LblKasa.Text = oku[0].ToString() + "  TL  ";

            }
            bgl.bağlanti().Close();

            //Tekrarsız Olarak Ayları Listeleme

            SqlCommand komut2 = new SqlCommand("Select distinct(OdemeAy) from Kasa", bgl.bağlanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            { 
            comboBox1.Items.Add(oku2[0].ToString());
            }
            bgl.bağlanti().Close();

            SqlCommand komut3 = new SqlCommand("select OdemeAy,sum(OdemeMiktar)from kasa group by OdemeAy", bgl.bağlanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while(oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3[0], oku3[1]);

            }
            bgl.bağlanti().Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select sum (OdemeMiktar) from Kasa where OdemeAy=@p1 ",bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader oku = komut.ExecuteReader();  
            while(oku.Read())
            {
                label3.Text = oku[0].ToString();
            }
            bgl.bağlanti().Close();
        }
    }
}
