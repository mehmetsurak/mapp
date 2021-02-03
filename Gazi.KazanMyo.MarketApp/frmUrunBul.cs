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
    public partial class frmUrunBul : Form
    {
        SqlConnection cn = null;
        //private int sonuc;

        public frmUrunBul()
        {

            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            //using (cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=MarketDb; Integrated Security=true"))
            using (cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Integrated Security=true;Initial Catalog=MarketDb"))


            {
                using (SqlCommand cmd = new SqlCommand("Select UrunId,UrunAd,Fiyat,Stok from tblMarket Where UrunAd=@UrunAd)", cn))


                {
                    SqlParameter[] p = { new SqlParameter("@UrunAd", txtUrunAd.Text) };

                    cmd.Parameters.AddRange(p);
                    if (cn != null && cn.State != ConnectionState.Open)
                    {
                        cn.Open();
                    }

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Form1 frm = (Form1)Application.OpenForms["Form1"];
                        frm.txtUrunAd.Text = dr["UrunAd"].ToString();
                        frm.txtUrunAd.Text = dr["Fiyat"].ToString();
                        frm.txtUrunAd.Text = dr["Stok"].ToString();
                        frm.urunid = Convert.ToInt32(dr["UrunId"]);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci Bulunamadı");
                    }
                    dr.Close();
                }
            }
        }

        //Deneme Class'ı IDısposable interface'ini implement(uygulamak) etti.
        class Deneme : IDisposable
        {
            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }
    }
}
