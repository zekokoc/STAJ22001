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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonDataSet4.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter2.Fill(this.yurtOtomasyonDataSet4.Borclar);
            // TODO: Bu kod satırı 'yurtOtomasyonDataSet3.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter1.Fill(this.yurtOtomasyonDataSet3.Borclar);
            // TODO: Bu kod satırı 'yurtOtomasyonDataSet2.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter.Fill(this.yurtOtomasyonDataSet2.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtAd1.Text = ad;
            TxtOgrİD1.Text = id;
            TxtSoyad1.Text = soyad;
            TxtKalan.Text = kalan;

        }

        private void BtnÖdemeAl_Click(object sender, EventArgs e)
        {

            //Ödenen tutarı kalan tutardan düşme
            int ödenen, kalan, yeniborc;
            ödenen = Convert.ToInt16(TxtOdenen.Text);
            kalan = Convert.ToInt16(TxtKalan.Text);
            yeniborc = kalan - ödenen;
            TxtKalan.Text = yeniborc.ToString();

            //Yeni tutarı veritabanına kaydetme

            SqlCommand komut = new SqlCommand("update Borclar set OgrKalanBorc=@p1  where Ogrid=@p2 ", bgl.bağlanti());
            komut.Parameters.AddWithValue("@p2", TxtOgrİD1.Text);
            komut.Parameters.AddWithValue("@p1", TxtKalan.Text);
            komut.ExecuteNonQuery();
            bgl.bağlanti().Close();
            MessageBox.Show("Borç  Ödendi.....");
            this.borclarTableAdapter2.Fill(this.yurtOtomasyonDataSet4.Borclar);

            // Kasa Tablosuna Ekleme Yapma

            SqlCommand komut2 = new SqlCommand("insert into Kasa (OdemeAy,OdemeMiktar) values (@k1,@k2)", bgl.bağlanti());
            komut2.Parameters.AddWithValue("@k1", TxtOdenenAy.Text);
            komut2.Parameters.AddWithValue("@k2", TxtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.bağlanti().Close();
        }
    }
}
