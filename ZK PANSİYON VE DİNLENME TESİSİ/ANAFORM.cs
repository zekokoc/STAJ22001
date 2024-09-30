using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZK_PANSİYON_VE_DİNLENME_TESİSİ
{
    public partial class ANAFORM : Form
    {
        public ANAFORM()
        {
            InitializeComponent();
        }

        private void BtnAdminGiris_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnYeniMüsteri_Click(object sender, EventArgs e)
        {
            Frm_Musteri fr = new Frm_Musteri();
            fr.Show(); 

        }

        private void BtnOdalar_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MüsteriBilgileri fr = new MüsteriBilgileri();
            fr.Show();
        }

        private void BtnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ZK PANSİYON VE DİNLENME TESİSLERİ / 2024 - İSTANBUL");
        }

        private void ANAFORM_Load(object sender, EventArgs e)
        {
           timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnPersonelMaas_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.Show();
        }

        private void BtnStok_Click(object sender, EventArgs e)
        {
            FrmStok fr = new FrmStok();
            fr.Show();
        }

        private void BtnRadyo_Click(object sender, EventArgs e)
        {
            FRMRADYO fr = new FRMRADYO();
            fr.Show();
        }

        private void BtnSifreGüncelle_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle fr = new FrmSifreGuncelle();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMesajlarcs fr= new FrmMesajlarcs();
            fr.Show();
        }
    }
}
