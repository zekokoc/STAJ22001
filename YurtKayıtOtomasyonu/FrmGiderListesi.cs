using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayıtOtomasyonu
{
    public partial class FrmGiderListesi : Form
    {
        public FrmGiderListesi()
        {
            InitializeComponent();
        }

        private void FrmGiderListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonDataSet6.Giderler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.giderlerTableAdapter.Fill(this.yurtOtomasyonDataSet6.Giderler);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen;
            FrmGiderGüncelle frg = new FrmGiderGüncelle();
            seçilen = dataGridView1.SelectedCells[0].RowIndex;
            frg.id = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            frg.elektrik = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            frg.su = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            frg.doğalgaz = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            frg.internet = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();
            frg.gıda = dataGridView1.Rows[seçilen].Cells[5].Value.ToString();
            frg.personel = dataGridView1.Rows[seçilen].Cells[6].Value.ToString();
            frg.diğer = dataGridView1.Rows[seçilen].Cells[7].Value.ToString();
            frg.Show();
        }
    }   
}
