using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ZK_PANSİYON_VE_DİNLENME_TESİSİ
{
    public partial class FrmMesajlarcs : Form
    {
        public FrmMesajlarcs()
        {
            InitializeComponent();
        }
       SqlConnection bağlanti = new SqlConnection("Data Source=DESKTOP-0OEVPEH\\SQLEXPRESS;Initial Catalog=ZkPansiyon;Integrated Security=True");
        private void verilerigoster()

        {
            listView1.Items.Clear();
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("select * from Mesajlar", bağlanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mesajid"].ToString();
                ekle.SubItems.Add(oku["Adsoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());
               

                listView1.Items.Add(ekle);


            }
            bağlanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("insert into Mesajlar (Adsoyad,Mesaj) values ('"+textBox1.Text+"',+'"+richTextBox1.Text+"')",bağlanti);
            komut.ExecuteNonQuery();
            bağlanti.Close() ;
            verilerigoster();
            MessageBox.Show("Kayıt Başarılı...");
        }

        private void FrmMesajlarcs_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
