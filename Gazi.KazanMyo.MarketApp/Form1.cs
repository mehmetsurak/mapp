using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazi.KazanMyo.MarketApp
{
    public partial class Form1 : Form
    {
        SqlConnection cn = null;
        public int urunid = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Sql Server'a Bağlantı Yapacağız.
        //ConnectionString: Sql  Server Adresi,Gereken kimlik doğrulama bilgileri,(User=sa;Password:123),Veritabanı Adı
        //Insert,Update,Delete:ExecuteNonQuery
        //Select:ExecuteReader()
        //SqlInjection ' '+123' '
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Integrated Security=true;Initial Catalog=MarketDb"))
                {
                    using (SqlCommand cmd = new SqlCommand("Insert into tblMarket values(@UrunAd,@Fiyat,@Stok)", cn)
)
                    {
                        //SqlCommand cmd = new SqlCommand($"Insert into tblMarket (UrunAd,Fiyat,Stok)values ('{txtUrunAd.Text}','{txtFiyat.Text}','{txtStok.Text}')" , cn);//
                        SqlParameter[] p = { new SqlParameter("@UrunAd", txtUrunAd.Text), new SqlParameter("@Fiyat", txtFiyat.Text), new SqlParameter("@Stok", txtStok.Text) };

                        cmd.Parameters.AddRange(p);
                        if (cn != null && cn.State != ConnectionState.Open)
                        {
                            cn.Open();
                        }

                        int sonuc = cmd.ExecuteNonQuery();
                        if (sonuc>0)
                        {
                            MessageBox.Show("İşlem Başarılı");
                            Temizle();
                        }
                        else
                        {
                            MessageBox.Show("İşlem Başarısız!!");
                        }
                        cn.Close();

                        MessageBox.Show(sonuc > 0 ? "Kayıt İşlemi Başarılı!" : "Kayıt İşlemi Başarısız!!");

                    }
                }
            }

            catch (Exception)
            {
                throw;
                //MessageBox.Show("Bir Hata Oluştu");
            }



            //SqlParameter p = new SqlParameter("@UrunAd", txtUrunAd.Text);
            //SqlParameter p1 = new SqlParameter("@Fiyat",txtFiyat.Text);
            //SqlParameter p2 = new SqlParameter("@Stok", txtStok.Text);

            //cmd.Parameters.Add(p);
            //cmd.Parameters.Add(p1);
            //cmd.Parameters.Add(p2);


            //cn.Open();
            //cmd.ExecuteNonQuery();
            //cn.Close();
        }

        private void txtUrunAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            frmUrunBul frm = new frmUrunBul();
            frm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Integrated Security=true;Initial Catalog=MarketDb"))
            {
                using (SqlCommand cmd = new SqlCommand("Update tblMarket set UrunAd=@UrunAd,Fiyat=@Fiyat,Stok=@Stok where UrunId=@UrunId", cn)
)
                {
                    SqlParameter[] p = { new SqlParameter("@UrunAd", txtUrunAd.Text), new SqlParameter("@Fiyat", txtFiyat.Text), new SqlParameter("@Stok", txtStok.Text), new SqlParameter("@UrunId", urunid) };

                    cmd.Parameters.AddRange(p);
                    if (cn != null && cn.State != ConnectionState.Open)
                    {
                        cn.Open();
                    }

                    int sonuc = cmd.ExecuteNonQuery();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("İşlem Başarılı");
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("İşlem Başarısız");
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (urunid == 0)
            {
                MessageBox.Show("Önce Ürünü Seçmelisiniz!!");
            }
            else
            {
                DialogResult cvp = MessageBox.Show("Ürünü Silmek İstediğinizden Emin misiniz?", "Kayıt Silme Onayı", MessageBoxButtons.YesNo);
                if (cvp == DialogResult.Yes)
                {
                    using (cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Integrated Security=true;Initial Catalog=MarketDb"))
                    {
                        using (SqlCommand cmd = new SqlCommand("Delete from tblMarket where UrunId=@UrunId", cn)
        )
                        {
                            SqlParameter[] p = { new SqlParameter("@UrunId", urunid) };

                            cmd.Parameters.AddRange(p);
                            if (cn != null && cn.State != ConnectionState.Open)
                            {
                                cn.Open();
                            }
                            int sonuc = cmd.ExecuteNonQuery();
                            if (sonuc>0)
                            {
                                MessageBox.Show("İşlem Başarılı");
                                Temizle();
                            }
                            else
                            {
                                MessageBox.Show("İşlem Başarısız!!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt Silme İşlemi İptal Edildi.");
                }
            }
        }
        void Temizle()
        {
            txtFiyat.Text = string.Empty;
            txtStok.Text = string.Empty;
            txtUrunAd.Text = string.Empty;
            urunid = 0;
        }
    }
}
