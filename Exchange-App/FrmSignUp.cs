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

namespace Exchange_App
{
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2BOGKJG;Initial Catalog=yazilimYapimi;Integrated Security=True");

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmSignUp_Load(object sender, EventArgs e)
        {
            txtKullaniciAdi.Focus();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutEkle = new SqlCommand("insert into Kullanicilar (kullaniciAdi,kullaniciParola,ad,soyad,tckimlikNo,telefonNo,adres,eMail) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
            komutEkle.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komutEkle.Parameters.AddWithValue("@p2", textPassword.Text);
            komutEkle.Parameters.AddWithValue("@p3", txtAd.Text);
            komutEkle.Parameters.AddWithValue("@p4", txtSoyad.Text);
            komutEkle.Parameters.AddWithValue("@p5", txtTC.Text);
            komutEkle.Parameters.AddWithValue("@p6", txtTelefon.Text);
            komutEkle.Parameters.AddWithValue("@p7", rtxtAdres.Text);
            komutEkle.Parameters.AddWithValue("@p8", txtEmail.Text);
            komutEkle.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            SqlCommand komutid = new SqlCommand("Select kullaniciID from Kullanicilar where kullaniciAdi=@p1", baglanti);
            komutid.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            string id = komutid.ExecuteScalar().ToString();
            baglanti.Close();

            baglanti.Open();
            SqlCommand komutTip = new SqlCommand("insert into kullaniciTipleri (kullanicitipAdi,kullaniciID) values(@p1,@p2)", baglanti);
            komutTip.Parameters.AddWithValue("@p1","user");
            komutTip.Parameters.AddWithValue("@p2", id);
            komutTip.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kayıt işlemi başarılı");

        }
    }
}
