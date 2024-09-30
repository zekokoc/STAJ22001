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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet.Bolumler);

        }

        private void PcbEkle_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut1 = new SqlCommand("insert into Bolumler (BolumAd) values (@p1)", bgl.bağlanti());
                komut1.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut1.ExecuteNonQuery();
                bgl.bağlanti().Close();
                MessageBox.Show("Bölüm Ekleme Başarılı...");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet.Bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!!! Yeniden deneyin...");
            }

        }

        private void PcbSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand("delete Bolumler where Bolumid=@p1", bgl.bağlanti());
                komut2.Parameters.AddWithValue("@p1", TxtBolumİd.Text);
                komut2.ExecuteNonQuery();
                bgl.bağlanti().Close();
                MessageBox.Show("Bölüm Silme Başarılı...");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet.Bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!!! Yeniden deneyin...");
            }
        }

        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtBolumİd.Text = id;
            TxtBolumAd.Text = bolumad;
        }

        private void PcbDüzenle_Click(object sender, EventArgs e)
        {

            try
            {

                SqlCommand komut2 = new SqlCommand("update Bolumler set BolumAd =@p1 where Bolumid= @p2", bgl.bağlanti());
                komut2.Parameters.AddWithValue("@p2", TxtBolumİd.Text);
                komut2.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut2.ExecuteNonQuery();
                bgl.bağlanti().Close();
                MessageBox.Show("Güncelleme İşlemi Başarılı...");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet.Bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!!! Yeniden deneyin...");
            }
        }
    }
}
